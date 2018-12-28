using System;

namespace AspNetMvc.Api.Domains.Dtos.Common
{
    public class Status
    {
        #region Properties | Fields

        public int Id { get; set; }

        public DateTime InsertDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        public int UpdatePersonId { get; set; }

        public string Identifier { get; set; }

        public string Name { get; set; }

        public Status()
        {
            InsertDate = InsertDate > DateTime.MinValue ? InsertDate : DateTime.Now;
            UpdateDate = UpdateDate.HasValue && UpdateDate.Value > DateTime.MinValue ? UpdateDate.Value : DateTime.Now;
        }

        #endregion
    }
}
