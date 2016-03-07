﻿using Skybrud.Siteimprove.Endpoints.Raw;

namespace Skybrud.Siteimprove.Endpoints {

    public class SiteimproveQualityAssuranceEndpoint {

        #region Properties

        /// <summary>
        /// A reference to the Siteimprove service.
        /// </summary>
        public SiteimproveService Service { get; private set; }

        /// <summary>
        /// A reference to the raw endpoint.
        /// </summary>
        public SiteimproveQualityAssuranceRawEndpoint Raw {
            get { return Service.Client.QualityAssurance; }
        }

        public SiteimproveBrokenLinksEndpoint BrokenLinks { get; private set; }

        public SiteimproveSpellingEndpoint Spelling { get; private set; }

        #endregion

        #region Constructors

        internal SiteimproveQualityAssuranceEndpoint(SiteimproveService service) {
            Service = service;
            BrokenLinks = new SiteimproveBrokenLinksEndpoint(service);
            Spelling = new SiteimproveSpellingEndpoint(service);
        }

        #endregion

    }

}