/*
 * MessageMediaMessages.PCL
 *
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using APIMATIC.SDK.Common;


namespace MessageMedia.Messages.Models
{
    public class ConfirmDeliveryReportsAsReceivedRequest : BaseModel 
    {
        // These fields hold the values for the public properties.
        private List<string> deliveryReportIds;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("delivery_report_ids")]
        public List<string> DeliveryReportIds 
        { 
            get 
            {
                return this.deliveryReportIds; 
            } 
            set 
            {
                this.deliveryReportIds = value;
                onPropertyChanged("DeliveryReportIds");
            }
        }
    }
} 