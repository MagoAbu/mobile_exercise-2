using System;
using System.Collections.Generic;
using System.Text;

namespace atFrameWork2.TestEntities
{
    public class PortalInfo
    {
        public PortalInfo(Uri portalUri, Bitrix24_Project portalAdmin)
        {
            PortalUri = portalUri ?? throw new ArgumentNullException(nameof(portalUri));
            PortalAdmin = portalAdmin ?? throw new ArgumentNullException(nameof(portalAdmin));
        }

        public Uri PortalUri { get; }
        public Bitrix24_Project PortalAdmin { get; }
    }
}
