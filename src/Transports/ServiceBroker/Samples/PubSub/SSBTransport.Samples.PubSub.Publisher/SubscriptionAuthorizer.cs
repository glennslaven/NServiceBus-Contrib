﻿using System.Collections.Generic;
using NServiceBus;

namespace SSBTransport.Samples.PubSub.Publisher
{
    public class SubscriptionAuthorizer : IAuthorizeSubscriptions
    {
        public bool AuthorizeSubscribe(string messageType, string clientEndpoint, IDictionary<string, string> headers)
        {
            return true;
        }

        public bool AuthorizeUnsubscribe(string messageType, string clientEndpoint, IDictionary<string, string> headers)
        {
            return true;
        }
    }
}
