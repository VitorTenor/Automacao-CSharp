using AutomaçãoCSharp.Util;
using OpenQA.Selenium;
using Projeto1.Pages.Youtube;
using System;
using TechTalk.SpecFlow;

namespace Projeto1.Steps
{
    [Binding]
    public class TocarMusicaSteps
    {
        string urlyt = "https://www.youtube.com/";
        IWebDriver driver;
        BuscaYT buscayt;

        [Given(@"eu acesso o site do youtube")]
        public void DadoEuAcessoOSiteDoYoutube()
        {
            driver = Util.IniciarDriver();
            buscayt = new BuscaYT(driver);

            buscayt.AcessarSiteYT(urlyt);
        }
        
        [Given(@"digito a musica")]
        public void DadoDigitoAMusica()
        {
            buscayt.preenchercampobusca();
        }

        [Given(@"clico em buscar")]
        public void DadoClicoEmBuscar()
        {
            buscayt.clicoembuscar();
        }

        [When(@"seleciono a musica")]
        public void QuandoSelecionoAMusica()
        {
            buscayt.clicomusica();
        }
        [Then(@"valido se a musica esta tocando")]
        public void EntaoValidoSeAMusicaEstaTocando()
        {
            buscayt.verificamusica();
        }
    }
}
