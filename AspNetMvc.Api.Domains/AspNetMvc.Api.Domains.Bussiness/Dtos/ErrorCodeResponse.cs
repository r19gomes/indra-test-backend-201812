namespace AspNetMvc.Api.Domains.Dtos
{
    public class ErrorCodeResponse
    {
        public const int VALIDATION_EMPTY_FIELD = 1001;
        public const int VALIDATION_REQUIRED_FIELD = 1002;
        public const int VALIDATION_INVALID_FIELD = 1003;
        public const int VALIDATION_PRICE_CHANGE = 1004;
        public const int VALIDATION_NOT_FOUND = 1005;
        public const int VALIDATION_START_DATE_IS_FREATER_THAN_END_DATE = 1006;
        public const int EXCEPTION_SELECT = 1050;
        public const int EXCEPTION_UPDATE = 1051;
        public const int EXCEPTION_DELETE = 1052;
        public const int EXCEPTION_INSERT = 1053;
    }

}
