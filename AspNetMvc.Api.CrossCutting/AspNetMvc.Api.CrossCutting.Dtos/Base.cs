using AspNetMvc.Api.CrossCutting.Dtos.Common;
using System;

namespace AspNetMvc.Api.CrossCutting.Dtos
{
    public class Base
    {
        #region Properties | Fields

        public int Id { get; set; }

        public Status Status { get; set; }

        public DateTime InsertDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        public int UpdatePersonId { get; set; }

        #endregion

        #region Builders

        public Base()
        {
            InsertDate = InsertDate > DateTime.MinValue ? InsertDate : DateTime.Now;
            UpdateDate = UpdateDate.HasValue && UpdateDate.Value > DateTime.MinValue ? UpdateDate.Value : DateTime.Now;
        }

        public Base(Base dto)
        {
            if (dto != null)
            {
                this.Id = dto.Id;
                if (dto.Status != null)
                    Status = new Status()
                    {
                        Id = dto.Status.Id,
                        Name = dto.Status.Name,
                        Identifier = dto.Status.Identifier,
                        InsertDate = dto.Status.InsertDate,
                        UpdateDate = dto.Status.UpdateDate,
                        UpdatePersonId = dto.Status.UpdatePersonId
                    };
                this.InsertDate = dto.InsertDate;
                this.UpdateDate = dto.UpdateDate;
                this.UpdatePersonId = dto.UpdatePersonId;
            }
        }

        #endregion
    }

}
