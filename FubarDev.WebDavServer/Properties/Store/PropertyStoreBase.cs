﻿using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

using FubarDev.WebDavServer.FileSystem;
using FubarDev.WebDavServer.Properties.Dead;

using JetBrains.Annotations;

namespace FubarDev.WebDavServer.Properties.Store
{
    public abstract class PropertyStoreBase : IPropertyStore
    {
        protected PropertyStoreBase([NotNull] IDeadPropertyFactory deadPropertyFactory)
        {
            DeadPropertyFactory = deadPropertyFactory;
        }

        public abstract int Cost { get; }

        public IDeadPropertyFactory DeadPropertyFactory { get; }

        public virtual async Task<XElement> GetAsync(IEntry entry, XName name, CancellationToken cancellationToken)
        {
            var elements = await GetAsync(entry, cancellationToken).ConfigureAwait(false);
            return elements.FirstOrDefault(x => x.Name == name);
        }

        public virtual Task SetAsync(IEntry entry, XElement element, CancellationToken cancellationToken)
        {
            return SetAsync(entry, new[] {element}, cancellationToken);
        }

        public virtual async Task<bool> RemoveAsync(IEntry entry, XName name, CancellationToken cancellationToken)
        {
            return (await RemoveAsync(entry, new[] {name}, cancellationToken).ConfigureAwait(false)).Single();
        }

        public abstract Task<IReadOnlyCollection<XElement>> GetAsync(IEntry entry, CancellationToken cancellationToken);
        public abstract Task SetAsync(IEntry entry, IEnumerable<XElement> properties, CancellationToken cancellationToken);
        public abstract Task<IReadOnlyCollection<bool>> RemoveAsync(IEntry entry, IEnumerable<XName> names, CancellationToken cancellationToken);

        public virtual async Task RemoveAsync(IEntry entry, CancellationToken cancellationToken)
        {
            var elements = await GetAsync(entry, cancellationToken).ConfigureAwait(false);
            await RemoveAsync(entry, elements.Select(x => x.Name), cancellationToken).ConfigureAwait(false);
        }

        public virtual async Task<IDeadProperty> LoadAsync(IEntry entry, XName name, CancellationToken cancellationToken)
        {
            var element = await GetAsync(entry, name, cancellationToken).ConfigureAwait(false);
            return CreateProperty(entry, element);
        }

        public virtual async Task<IReadOnlyCollection<IDeadProperty>> LoadAsync(IEntry entry, CancellationToken cancellationToken)
        {
            var elements = await GetAsync(entry, cancellationToken).ConfigureAwait(false);
            return elements.Select(x => CreateProperty(entry, x)).ToList();
        }

        public virtual async Task<EntityTag> GetETagAsync(IDocument document, CancellationToken cancellationToken)
        {
            var etag = await GetAsync(document, EntityTag.PropertyName, cancellationToken).ConfigureAwait(false);
            if (etag == null)
            {
                etag = new EntityTag().ToXml();
                await SetAsync(document, etag, cancellationToken).ConfigureAwait(false);
            }

            return EntityTag.FromXml(etag);
        }

        public virtual async Task<EntityTag> UpdateETagAsync(IDocument document, CancellationToken cancellationToken)
        {
            var etag = EntityTag.FromXml(null);
            var etagElement = etag.ToXml();
            await SetAsync(document, etagElement, cancellationToken).ConfigureAwait(false);
            return etag;
        }

        private IDeadProperty CreateProperty(IEntry entry, XElement element)
        {
            return DeadPropertyFactory.Create(this, entry, element);
        }
    }
}
