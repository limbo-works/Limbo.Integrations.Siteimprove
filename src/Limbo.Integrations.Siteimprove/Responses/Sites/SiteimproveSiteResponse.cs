using Limbo.Integrations.Siteimprove.Models.Sites;
using Skybrud.Essentials.Http;

namespace Limbo.Integrations.Siteimprove.Responses.Sites {

    public class SiteimproveSiteResponse : SiteimproveResponse<SiteimproveSite> {

        /// <summary>
        /// Initializes a new instance based on the specified <paramref name="response"/>.
        /// </summary>
        /// <param name="response">The underlying raw response the instance should be based on.</param>
        public SiteimproveSiteResponse(IHttpResponse response) : base(response) {
            Body = ParseJsonObject(response.Body, SiteimproveSite.Parse);
        }

    }

}