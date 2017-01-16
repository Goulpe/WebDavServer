﻿using System;
using System.Threading;
using System.Threading.Tasks;

using FubarDev.WebDavServer.Model;

namespace FubarDev.WebDavServer.Handlers
{
    public interface IPropFindHandler : IHandler
    {
        Task<IWebDavResult> PropFindAsync(string path, Propfind request, Depth depth, CancellationToken cancellationToken);
    }
}