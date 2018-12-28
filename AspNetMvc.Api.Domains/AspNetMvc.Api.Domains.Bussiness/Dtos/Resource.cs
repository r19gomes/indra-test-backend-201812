using System.Collections.Generic;
using System.Linq;

namespace AspNetMvc.Api.Domains.Dtos
{
    public interface IResource
    {
        IDictionary<int, string> ResourceErrorCodeList { get; set; }
    }

    public class Resource : IResource
    {
        public IDictionary<int, string> ResourceErrorCodeList { get; set; }

        public Resource(IResource Resource = null)
        {
            this.ResourceErrorCodeList = new Dictionary<int, string>();
            this.ResourceErrorCodeList.Add(ErrorCodeResponse.VALIDATION_EMPTY_FIELD, "EMPTY_FIELD");
            this.ResourceErrorCodeList.Add(ErrorCodeResponse.VALIDATION_REQUIRED_FIELD, "REQUIRED_FIELD");
            this.ResourceErrorCodeList.Add(ErrorCodeResponse.VALIDATION_INVALID_FIELD, "INVALID_FIELD");
            this.ResourceErrorCodeList.Add(ErrorCodeResponse.VALIDATION_PRICE_CHANGE, "PRICE_CHANGE");
            this.ResourceErrorCodeList.Add(ErrorCodeResponse.VALIDATION_NOT_FOUND, "NOT_FOUND");
            this.ResourceErrorCodeList.Add(ErrorCodeResponse.VALIDATION_START_DATE_IS_FREATER_THAN_END_DATE, "START_DATE_IS_FREATER_THAN_END_DATE");

            if (Resource != null)
                Add(Resource);
        }

        private void Add(IResource Resource)
        {
            ResourceErrorCodeList.ToList().ForEach(x => this.ResourceErrorCodeList.Add(x));
        }

        public bool Exist(int ErrorCode)
        {
            return this.ResourceErrorCodeList.ContainsKey(ErrorCode);
        }

        public string GetById(int errorCode)
        {
            return this.ResourceErrorCodeList.ContainsKey(errorCode) ? this.ResourceErrorCodeList[errorCode] : null;
        }

    }

}
