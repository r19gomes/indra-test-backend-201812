namespace AspNetMvc.Api.CrossCutting.Dtos.ContaCorrente
{
    public class ContaCorrente : Base
    {
        public ContaCorrente(Base dto = null) : base(dto) { }

        public string Name { get; set; }

    }
}
