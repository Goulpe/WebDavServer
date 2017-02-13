﻿// <copyright file="WebDavHost.cs" company="Fubar Development Junker">
// Copyright (c) Fubar Development Junker. All rights reserved.
// </copyright>

using System;
using System.Linq;
using System.Text;

using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;

namespace FubarDev.WebDavServer.AspNetCore
{
    public class WebDavHost : IWebDavHost
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        private readonly Lazy<Uri> _baseUrl;

        public WebDavHost(IHttpContextAccessor httpContextAccessor, IOptions<WebDavHostOptions> options)
        {
            var opt = options?.Value ?? new WebDavHostOptions();
            _httpContextAccessor = httpContextAccessor;
            _baseUrl = new Lazy<Uri>(() => BuildBaseUrl(httpContextAccessor.HttpContext, opt));
        }

        public Uri BaseUrl => _baseUrl.Value;

        public string RequestProtocol => _httpContextAccessor.HttpContext.Request.Protocol;

        public DetectedClient DetectedClient
        {
            get
            {
                var userAgent = _httpContextAccessor.HttpContext.Request.Headers["User-Agent"].FirstOrDefault();
                if (string.IsNullOrEmpty(userAgent))
                    return DetectedClient.Any;

                if (userAgent.StartsWith("Microsoft-WebDAV-MiniRedir"))
                    return DetectedClient.MicrosoftExplorer;

                return DetectedClient.Any;
            }
        }

        private static Uri BuildBaseUrl(HttpContext httpContext, WebDavHostOptions options)
        {
            var result = new StringBuilder();
            if (options.BaseUrl != null)
            {
                result.Append(options.BaseUrl);
                if (!options.BaseUrl.EndsWith("/", StringComparison.Ordinal))
                    result.Append("/");
            }
            else
            {
                var request = httpContext.Request;
                var pathBase = request.PathBase.ToString();
                result.Append(request.Scheme).Append("://").Append(request.Host).Append(pathBase);
                if (!pathBase.EndsWith("/", StringComparison.Ordinal))
                    result.Append("/");
            }

            return new Uri(result.ToString());
        }
    }
}