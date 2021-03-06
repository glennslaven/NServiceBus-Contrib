﻿using System.Configuration;

namespace NServiceBus.Config
{
    public class ServiceBrokerTransportConfig : ConfigurationSection
    {
        /// <summary>
        /// Sets the maximum interval, in seconds, that a thread
        /// waits to receive messages from the queue before giving up.
        /// 
        /// The default value is 10.
        /// </summary>
        [ConfigurationProperty("SecondsToWaitForMessage", IsRequired = false)]
        public int? SecondsToWaitForMessage
        {
            get { return (int?) this["SecondsToWaitForMessage"]; }
            set { this["SecondsToWaitForMessage"] = value; }
        }

        /// <summary>
        /// Whether to end conversations after receiving messages from SSSB and 
        /// determining that there are no messages forming part of said 
        /// conversation left on the input queue.
        ///
        /// The default value is false.
        /// </summary>
        [ConfigurationProperty("EndConversationAfterReceive", IsRequired = false)]
        public bool? EndConversationAfterReceive
        {
            get { return (bool?) this["EndConversationAfterReceive"]; }
            set { this["EndConversationAfterReceive"] = value; }
        }

        /// <summary>
        /// Sets the maximum number of messages to be fetched in a
        /// RECEIVE statement.
        /// 
        /// The default value is 50.
        /// </summary>
        [ConfigurationProperty("ReceiveBatchSize", IsRequired = false)]
        public int? ReceiveBatchSize
        {
            get { return (int?) this["ReceiveBatchSize"]; }
            set { this["ReceiveBatchSize"] = value; }
        }

        /// <summary>
        /// The connection string used to connect to SSB.
        /// </summary>
        [ConfigurationProperty("ConnectionString", IsRequired = false)]
        public string ConnectionString
        {
            get { return (string) this["ConnectionString"]; }
            set { this["ConnectionString"] = value; }
        }

        /// <summary>
        /// SSB Service configured as the conversation initiator if none present in message headers.
        /// </summary>
        [ConfigurationProperty("InitiatorService", IsRequired = false)]
        public string InitiatorService
        {
            get { return (string) this["InitiatorService"]; }
            set { this["InitiatorService"] = value; }
        }
    }
}