using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1stPrototype.Enumeradores;
using _1stPrototype.Classes.Objetos;

namespace _1stPrototype.Classes.Relacionamentos
{
    public class EfeitoAcao
    {
        public enumEfeitoAcao efeito;
        public float teorMultiplicacao; // Teor total a ser aplicado em forma de multiplicação.
        public float teorSoma; // Teor total a ser aplicado em forma de soma.
        public bool blnSomaPrimeiro; // Indica se será feito a soma ou a multiplicação primeiro.

        public void DoAplicaEfeito(Human human)
        {
            // TODO FIXME APLICAR EFEITOS. Cada um do enum.
            switch(efeito)
            {
                case enumEfeitoAcao.DEV_PILAR_HUMANO:
                    human.mfltHumano = DoCalculaConstante(human.mfltHumano);
                    break;
                case enumEfeitoAcao.DEV_PILAR_EMPIRICO:
                    human.mfltEmpirico = DoCalculaConstante(human.mfltEmpirico);
                    break;
                case enumEfeitoAcao.DEV_PILAR_FILOSOFICO:
                    human.mfltFilosofico = DoCalculaConstante(human.mfltFilosofico);
                    break;
                case enumEfeitoAcao.DEV_PILAR_TEOLOGICO:
                    human.mfltTeologico = DoCalculaConstante(human.mfltTeologico);
                    break;
                case enumEfeitoAcao.DEV_PILAR_CIENTIFICO:
                    human.mfltCientifico = DoCalculaConstante(human.mfltCientifico);
                    break;
                case enumEfeitoAcao.ESTUDO_EXATAS:
                    human.mfltCienciasExatas = DoCalculaConstante(human.mfltCienciasExatas);
                    break;
                case enumEfeitoAcao.ESTUDO_BIOLOGICAS:
                    human.mfltCienciasBiologicas = DoCalculaConstante(human.mfltCienciasBiologicas);
                    break;
                case enumEfeitoAcao.ESTUDO_ENGENHARIAS:
                    human.mfltEngenharias = DoCalculaConstante(human.mfltEngenharias);
                    break;
                case enumEfeitoAcao.ESTUDO_SAUDE:
                    human.mfltCienciasSaude = DoCalculaConstante(human.mfltCienciasSaude);
                    break;
                case enumEfeitoAcao.ESTUDO_AGRARIA:
                    human.mfltCienciasAgrarias = DoCalculaConstante(human.mfltCienciasAgrarias);
                    break;
                case enumEfeitoAcao.ESTUDO_SOCIAIS:
                    human.mfltCienciasSociais = DoCalculaConstante(human.mfltCienciasSociais);
                    break;
                case enumEfeitoAcao.ESTUDO_HUMANAS:
                    human.mfltCienciasHumanas = DoCalculaConstante(human.mfltCienciasHumanas);
                    break;
                case enumEfeitoAcao.ESTUDO_LINGUISTICA:
                    human.mfltLinguistica = DoCalculaConstante(human.mfltLinguistica);
                    break;
                case enumEfeitoAcao.DEV_CEREBRO_MOTOR:
                    human.mfltCortexMotor = DoCalculaConstante(human.mfltCortexMotor);
                    break;
                case enumEfeitoAcao.DEV_CEREBRO_PRECISAO:
                    human.mfltCortexPreFrontal = DoCalculaConstante(human.mfltCortexPreFrontal);
                    break;
                case enumEfeitoAcao.DEV_CEREBRO_VISAO:
                    human.mfltLobosOccipitais = DoCalculaConstante(human.mfltLobosOccipitais);
                    break;
                case enumEfeitoAcao.DEV_CEREBRO_AUDICAO:
                    human.mfltLobosTemporais = DoCalculaConstante(human.mfltLobosTemporais);
                    break;
                case enumEfeitoAcao.DEV_CEREBRO_SENSOR:
                    human.mfltLobosParietais = DoCalculaConstante(human.mfltLobosParietais);
                    break;
                case enumEfeitoAcao.DEV_ESTABILIDADE_EMOCIONAL:
                    human.mfltInstabilidadeEmocional = DoCalculaConstante(human.mfltInstabilidadeEmocional);
                    break;
                case enumEfeitoAcao.DEV_ESTROVERSAO:
                    human.mfltExtroversao = DoCalculaConstante(human.mfltExtroversao);
                    break;
                case enumEfeitoAcao.DEV_AGRABILIDADE:
                    human.mfltAgradabilidade = DoCalculaConstante(human.mfltAgradabilidade);
                    break;
                case enumEfeitoAcao.DEV_CONSCIENCIABILIDADE:
                    human.mfltConsciencialidade = DoCalculaConstante(human.mfltConsciencialidade);
                    break;
                case enumEfeitoAcao.DEV_AVENTUREIRO:
                    human.mfltAberturaExperiencia = DoCalculaConstante(human.mfltAberturaExperiencia);
                    break;
                case enumEfeitoAcao.ALTERA_ENERGIA:
                    human.mfltEnergia = DoCalculaConstante(human.mfltEnergia);
                    break;
                case enumEfeitoAcao.ALTERA_FELICIDADE:
                    human.mfltFelicidade = DoCalculaConstante(human.mfltFelicidade);
                    break;
                case enumEfeitoAcao.ALTERA_FOME:
                    human.mfltFome = DoCalculaConstante(human.mfltFome);
                    break;
                case enumEfeitoAcao.ALTERA_INTELIGENCIA:
                    human.mfltInteligencia = DoCalculaConstante(human.mfltInteligencia);
                    break;
                case enumEfeitoAcao.ALTERA_SAUDE:
                    human.mfltSaude = DoCalculaConstante(human.mfltSaude);
                    break;
                case enumEfeitoAcao.ALTERA_BELEZA:
                    human.mfltBeleza = DoCalculaConstante(human.mfltBeleza);
                    break;
                case enumEfeitoAcao.ALTERA_CONSCIENCIA:
                    human.mfltConsciencia = DoCalculaConstante(human.mfltConsciencia);
                    break;
                case enumEfeitoAcao.DEV_PROF_LUTA_COPORTAL:
                    human.mfltProfLutaCorporal = DoCalculaConstante(human.mfltProfLutaCorporal);
                    break;
                case enumEfeitoAcao.DEV_PROF_ARMA_BRANCA:
                    human.mfltProfArmasBrancas = DoCalculaConstante(human.mfltProfArmasBrancas);
                    break;
                case enumEfeitoAcao.DEV_PROF_ARMA_FOGO:
                    human.mfltProfArmasFogo = DoCalculaConstante(human.mfltProfArmasFogo);
                    break;
                case enumEfeitoAcao.DEV_PROF_CARRO:
                    human.mfltProfCarros = DoCalculaConstante(human.mfltProfCarros);
                    break;
                case enumEfeitoAcao.DEV_PROF_MOTOS:
                    human.mfltProfMotos = DoCalculaConstante(human.mfltProfMotos);
                    break;
                case enumEfeitoAcao.DEV_PROF_TECNOLOGIA:
                    human.mfltProfTecnologia = DoCalculaConstante(human.mfltProfTecnologia);
                    break;
                case enumEfeitoAcao.DEV_PROF_SOCIAL:
                    human.mfltProfSocial = DoCalculaConstante(human.mfltProfSocial);
                    break;
                case enumEfeitoAcao.DEV_PROF_ARTISTICA:
                    human.mfltProfArtistica = DoCalculaConstante(human.mfltProfArtistica);
                    break;
                case enumEfeitoAcao.DEV_PROF_MUSICAL:
                    human.mfltProfMusical = DoCalculaConstante(human.mfltProfMusical);
                    break;
                case enumEfeitoAcao.DEV_PROF_MATEMATICA:
                    human.mfltProfMatematica = DoCalculaConstante(human.mfltProfMatematica);
                    break;
                case enumEfeitoAcao.DEV_PROF_PESQUISA:
                    human.mfltProfPesquisa = DoCalculaConstante(human.mfltProfPesquisa);
                    break;
                case enumEfeitoAcao.DEV_PROF_ESPACIAL:
                    human.mfltProfEspacial = DoCalculaConstante(human.mfltProfEspacial);
                    break;
                case enumEfeitoAcao.TENDENCIA_TRAPACA:
                    human.mfltTendTrapaca = DoCalculaConstante(human.mfltTendTrapaca);
                    break;
                case enumEfeitoAcao.TENDENCIA_ROUBO:
                    human.mfltTendRoubo = DoCalculaConstante(human.mfltTendRoubo);
                    break;
                case enumEfeitoAcao.TENDENCIA_DROGAS_LEVES:
                    human.mfltTendDrogasLeves = DoCalculaConstante(human.mfltTendDrogasLeves);
                    break;
                case enumEfeitoAcao.TENDENCIA_DROGAS_PESADAS:
                    human.mfltTendDrogasPesadas = DoCalculaConstante(human.mfltTendDrogasPesadas);
                    break;
                case enumEfeitoAcao.TENDENCIA_ESTUDAR:
                    human.mfltTendEstudar = DoCalculaConstante(human.mfltTendEstudar);
                    break;
                case enumEfeitoAcao.TENDENCIA_FESTA:
                    human.mfltTendFesta = DoCalculaConstante(human.mfltTendFesta);
                    break;
                case enumEfeitoAcao.TENDENCIA_SUICIDIO:
                    human.mfltTendSuicidio = DoCalculaConstante(human.mfltTendSuicidio);
                    break;
                case enumEfeitoAcao.TENDENCIA_DECISOES_EMOCIONAIS:
                    human.mfltTendDecisaoEmocional = DoCalculaConstante(human.mfltTendDecisaoEmocional);
                    break;
                case enumEfeitoAcao.TENDENCIA_PREGUICA:
                    human.mfltTendPreguica = DoCalculaConstante(human.mfltTendPreguica);
                    break;

            }
        }

        private float DoCalculaConstante(float original)
        {
            if(blnSomaPrimeiro)
            {
                original += teorSoma;
                original *= teorMultiplicacao;
            }
            else
            {
                original *= teorMultiplicacao;
                original += teorSoma;
            }

            return original;
        }
    }
}
