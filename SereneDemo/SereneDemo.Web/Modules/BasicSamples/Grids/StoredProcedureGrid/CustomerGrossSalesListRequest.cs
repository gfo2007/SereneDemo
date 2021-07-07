using Serenity.Services;
using System;

namespace SereneDemo.BasicSamples
{
    public class CustomerGrossSalesListRequest : ListRequest
    {
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}