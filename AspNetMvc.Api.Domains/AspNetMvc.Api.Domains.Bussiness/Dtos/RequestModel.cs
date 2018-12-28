namespace AspNetMvc.Api.Domains.Dtos
{
    public class RequestBase
    {
        #region Properties | Fields

        public string TokenId { get; set; }

        public bool UpdateNoSql { get; set; }

        public bool Reduce { get; set; }

        public bool UpdateOnlyMain { get; set; }

        #endregion

        #region Builders

        public RequestBase()
        {
            UpdateNoSql = true;
            UpdateOnlyMain = false;
        }

        #endregion
    }

    public class GenericRequest<T> : RequestBase where T : Base
    {
        #region Properties

        public T Request { get; set; }

        #endregion

        #region Builders

        public GenericRequest() { }

        public GenericRequest(T model)
        {
            Request = model;
        }

        #endregion
    }
}
