using AspNetMvc.Api.Infrastructures.DataAccess.Entities;
using System;
using System.Linq;
using static System.Console;
using DbContext = AspNetMvc.Api.Infrastructures.DataAccess.Contexts.DbContext;

namespace AppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Orquestrador da Carga...");

            int total = 0;

            using (var ctx = new DbContext())
            {
                #region BANCO 

                Console.WriteLine("Tabela: Banco...");

                total = ctx.Bancos.Count(x => int.Parse(x.Codigo) == 1);
                if (total == 0)
                    ctx.Add(
                        new Banco {
                            Codigo = "001",
                            Nome = "BANCO DO BRASIL S.A.",
                            Apelido = "BB",
                            NumeroCnpj = "00000000000000",
                            WebSiteOficial = @"http://www.bb.com.br",
                            FlagStatus = true,
                            CadastroUsuarioId = 1,
                            CadastroDataHora = DateTime.Now,
                            AtualizacaoUsuarioId = null,
                            AtualizacaoDataHora = null
                        }
                    );
                total = ctx.Bancos.Count(x => int.Parse(x.Codigo) == 2);
                if (total == 0)
                    ctx.Add(
                        new Banco {
                            Codigo = "002",
                            Nome = "BANCO CENTRAL DO BRASIL",
                            Apelido = "BACEN",
                            NumeroCnpj = "00038166000105",
                            WebSiteOficial = @"https://www.bcb.gov.br/pt-br/",
                            FlagStatus = true,
                            CadastroUsuarioId = 1,
                            CadastroDataHora = DateTime.Now,
                            AtualizacaoUsuarioId = null,
                            AtualizacaoDataHora = null
                        }
                    );
                total = ctx.Bancos.Count(x => int.Parse(x.Codigo) == 3);
                if (total == 0)
                    ctx.Add(
                        new Banco {
                            Codigo = "003",
                            Nome = "BANCO DA AMAZONIA S.A.",
                            Apelido = "BANCO AMAZ",
                            NumeroCnpj = "04902979000225",
                            WebSiteOficial = @"http://www.bancoamazonia.com.br",
                            FlagStatus = true,
                            CadastroUsuarioId = 1,
                            CadastroDataHora = DateTime.Now,
                            AtualizacaoUsuarioId = null,
                            AtualizacaoDataHora = null
                        }
                    );
                total = ctx.Bancos.Count(x => int.Parse(x.Codigo) == 4);
                if (total == 0)
                    ctx.Add(
                        new Banco {
                            Codigo = "004",
                            Nome = "BANCO DO NORDESTE DO BRASIL S.A.",
                            Apelido = "BANCO DO N",
                            NumeroCnpj = "07237373000200",
                            WebSiteOficial = @"http://www.banconordeste.gov.br",
                            FlagStatus = true,
                            CadastroUsuarioId = 1,
                            CadastroDataHora = DateTime.Now,
                            AtualizacaoUsuarioId = null,
                            AtualizacaoDataHora = null
                        }
                    );
                total = ctx.Bancos.Count(x => int.Parse(x.Codigo) == 6);
                if (total == 0)
                    ctx.Add(
                        new Banco {
                            Codigo = "006",
                            Nome = "BANCO BOSTON",
                            Apelido = "BANCO DO N",
                            NumeroCnpj = null,
                            WebSiteOficial = @"",
                            FlagStatus = true,
                            CadastroUsuarioId = 1,
                            CadastroDataHora = DateTime.Now,
                            AtualizacaoUsuarioId = null,
                            AtualizacaoDataHora = null
                        }
                    );
                total = ctx.Bancos.Count(x => int.Parse(x.Codigo) == 7);
                if (total == 0)
                    ctx.Add(
                        new Banco {
                            Codigo = "007",
                            Nome = "BNDES",
                            Apelido = "BANCO NACI",
                            NumeroCnpj = "33657248000189",
                            WebSiteOficial = @"",
                            FlagStatus = true,
                            CadastroUsuarioId = 1,
                            CadastroDataHora = DateTime.Now,
                            AtualizacaoUsuarioId = null,
                            AtualizacaoDataHora = null
                        }
                    );
                total = ctx.Bancos.Count(x => int.Parse(x.Codigo) == 8);
                if (total == 0)
                    ctx.Add(
                        new Banco {
                            Codigo = "0008",
                            Nome = "BANCO DO ESTADO DE SAO PAULO S",
                            Apelido = "BANCO MERI",
                            NumeroCnpj = "61411633000268",
                            WebSiteOficial = @"",
                            FlagStatus = true,
                            CadastroUsuarioId = 1,
                            CadastroDataHora = DateTime.Now,
                            AtualizacaoUsuarioId = null,
                            AtualizacaoDataHora = null
                        }
                    );
                total = ctx.Bancos.Count(x => int.Parse(x.Codigo) == 9);
                if (total == 0)
                    ctx.Add(
                        new Banco {
                            Codigo = "0009",
                            Nome = "BACEN",
                            Apelido = "BACEN",
                            NumeroCnpj = null,
                            WebSiteOficial = @"",
                            FlagStatus = true,
                            CadastroUsuarioId = 1,
                            CadastroDataHora = DateTime.Now,
                            AtualizacaoUsuarioId = null,
                            AtualizacaoDataHora = null
                        }
                    );
                //total = ctx.Bancos.Count(x => x.Codigo == "0010");
                //if (total == 0)
                //    ctx.Add(
                //        new Banco { Codigo = "0010", Nome = "CC Credicoamo", Apelido = "CC CREDICO", NumeroCnpj = "81723108000104" }
                //    );
                //total = ctx.Bancos.Count(x => x.Codigo == "0011");
                //if (total == 0)
                //    ctx.Add(
                //        new Banco { Codigo = "0011", Nome = "CREDIT SUISSE HEDGING GRIFFO C", Apelido = "CSHG", NumeroCnpj = "61809182000130" }
                //    );
                //total = ctx.Bancos.Count(x => x.Codigo == "0012");
                //if (total == 0)
                //    ctx.Add(
                //        new Banco { Codigo = "0012", Nome = "Banco Inbursa S.A.", Apelido = "BANCO STAN", NumeroCnpj = "04866275000163" }
                //    );
                //total = ctx.Bancos.Count(x => x.Codigo == "0013");
                //if (total == 0)
                //    ctx.Add(
                //        new Banco { Codigo = "0013", Nome = "SENSO CORRETORA DE CAMBIO E VA", Apelido = "SC Senso", NumeroCnpj = null }
                //    );
                //total = ctx.Bancos.Count(x => x.Codigo == "0014");
                //if (total == 0)
                //    ctx.Add(
                //        new Banco { Codigo = "0014", Nome = "Natixis Brasil", Apelido = "NATIXIS BR", NumeroCnpj = "09274232000102" }
                //    );
                //total = ctx.Bancos.Count(x => x.Codigo == "0015");
                //if (total == 0)
                //    ctx.Add(
                //        new Banco { Codigo = "0015", Nome = "SC UBS Brasil", Apelido = "SC UBS Bra", NumeroCnpj = "02819125000173" }
                //    );
                //total = ctx.Bancos.Count(x => x.Codigo == "0016");
                //if (total == 0)
                //    ctx.Add(
                //        new Banco { Codigo = "0016", Nome = "CC Sicoob Creditran", Apelido = "COOPERATIV", NumeroCnpj = "04715685000103" }
                //    );
                //total = ctx.Bancos.Count(x => x.Codigo == "0017");
                //if (total == 0)
                //    ctx.Add(
                //        new Banco { Codigo = "0017", Nome = "BNY MELLON S.A.", Apelido = "BNY MELLON", NumeroCnpj = "42272526000170" }
                //    );
                //total = ctx.Bancos.Count(x => x.Codigo == "0018");
                //if (total == 0)
                //    ctx.Add(
                //        new Banco { Codigo = "0018", Nome = "BM Tricury", Apelido = "BM TRICURY", NumeroCnpj = "57839805000014" }
                //    );
                //total = ctx.Bancos.Count(x => x.Codigo == "0019");
                //if (total == 0)
                //    ctx.Add(
                //        new Banco { Codigo = "0019", Nome = "BANCO AZTECA DO BRASIL S.A.", Apelido = "BANCO AZTE", NumeroCnpj = "09391857000154" }
                //    );
                //total = ctx.Bancos.Count(x => x.Codigo == "0020");
                //if (total == 0)
                //    ctx.Add(
                //        new Banco { Codigo = "0020", Nome = "BANCO DO ESTADO DE ALAGOAS S.A", Apelido = "BANCO DO E", NumeroCnpj = "12275749000201" }
                //    );
                //total = ctx.Bancos.Count(x => x.Codigo == "0021");
                //if (total == 0)
                //    ctx.Add(
                //        new Banco { Codigo = "0021", Nome = "BANESTES S.A BANCO DO ESTADO D", Apelido = "BANCO DO E", NumeroCnpj = "28127603000178" }
                //    );
                //total = ctx.Bancos.Count(x => x.Codigo == "0022");
                //if (total == 0)
                //    ctx.Add(
                //        new Banco { Codigo = "0022", Nome = "CREDIREAL  EM ABSORCAO", Apelido = "CREDIREAL", NumeroCnpj = "21562962000619" }
                //    );
                //total = ctx.Bancos.Count(x => x.Codigo == "0024");
                //if (total == 0)
                //    ctx.Add(
                //        new Banco { Codigo = "0024", Nome = "BANCO DE PERNAMBUCO S.A. BANDE", Apelido = "BANCO DO E", NumeroCnpj = "10866788000177" }
                //    );
                //total = ctx.Bancos.Count(x => x.Codigo == "0025");
                //if (total == 0)
                //    ctx.Add(
                //        new Banco { Codigo = "0025", Nome = "BANCO ALFA S/A", Apelido = "BANCO ALFA", NumeroCnpj = "03323840000183" }
                //    );
                //total = ctx.Bancos.Count(x => x.Codigo == "0026");
                //if (total == 0)
                //    ctx.Add(
                //        new Banco { Codigo = "0026", Nome = "BANCO DO ESTADO DO ACRE S.A.", Apelido = "BANCO DO E", NumeroCnpj = "04064077000186" }
                //    );
                //total = ctx.Bancos.Count(x => x.Codigo == "0027");
                //if (total == 0)
                //    ctx.Add(
                //        new Banco { Codigo = "0027", Nome = "BANCO DO ESTADO DE SANTA CATAR", Apelido = "BANCO DO E", NumeroCnpj = "83876003000200" }
                //    );
                //total = ctx.Bancos.Count(x => x.Codigo == "0028");
                //if (total == 0)
                //    ctx.Add(
                //        new Banco { Codigo = "0028", Nome = "BANEB EM ABSORCAO", Apelido = "BANCO DO E", NumeroCnpj = "15142490000138" }
                //    );
                ///*                                                                                                                                                


                // */
                ctx.SaveChanges();

                ctx.Bancos.ToList().ForEach(x =>
                    WriteLine($"{ x.BancoId } | código: { x.Codigo} | nome: { x.Nome} | apelido: { x.Apelido } | cnpj: {x.NumeroCnpj}"));


                #endregion 
            }

            ReadLine();
        }
    }
}
