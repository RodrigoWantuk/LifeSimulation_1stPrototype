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
                case DEV_PILAR_HUMANO:
                    human.mfltHumano = DoCalculaConstante(human.mfltHumano);
                    break;
                case DEV_PILAR_EMPIRICO:
                    human.mfltEmpirico = DoCalculaConstante(human.mfltEmpirico);
                    break;
                case DEV_PILAR_FILOSOFICO:
                    human.mfltFilosofico = DoCalculaConstante(human.mfltFilosofico);
                    break;
                case DEV_PILAR_TEOLOGICO:
                    human.mfltTeologico = DoCalculaConstante(human.mfltTeologico);
                    break;
                case DEV_PILAR_CIENTIFICO:
                    human.mfltCientifico = DoCalculaConstante(human.mfltCientifico);
                    break;
                case ESTUDO_EXATAS:
                    human.mfltCienciasExatas = DoCalculaConstante(human.mfltCienciasExatas);
                    break;
                case ESTUDO_BIOLOGICAS:
                    human.mfltCienciasBiologicas = DoCalculaConstante(human.mfltCienciasBiologicas);
                    break;
                case ESTUDO_ENGENHARIAS:
                    human.mfltEngenharias = DoCalculaConstante(human.mfltEngenharias);
                    break;
                case ESTUDO_SAUDE:
                    human.mfltCienciasSaude = DoCalculaConstante(human.mfltCienciasSaude);
                    break;
                case ESTUDO_AGRARIA:
                    human.mfltCienciasAgrarias = DoCalculaConstante(human.mfltCienciasAgrarias);
                    break;
                case ESTUDO_SOCIAIS:
                    human.mfltCienciasSociais = DoCalculaConstante(human.mfltCienciasSociais);
                    break;
                case ESTUDO_HUMANAS:
                    human.mfltCienciasHumanas = DoCalculaConstante(human.mfltCienciasHumanas);
                    break;
                case ESTUDO_LINGUISTICA:
                    human.mfltLinguistica = DoCalculaConstante(human.mfltLinguistica);
                    break;
                case DEV_CEREBRO_MOTOR:
                    human.mfltCortexMotor = DoCalculaConstante(human.mfltCortexMotor);
                    break;
                case DEV_CEREBRO_PRECISAO:
                    human.mfltCortexPreFrontal = DoCalculaConstante(human.mfltCortexPreFrontal);
                    break;
                case DEV_CEREBRO_VISAO:
                    human.mfltLobosOccipitais = DoCalculaConstante(human.mfltLobosOccipitais);
                    break;
                case DEV_CEREBRO_AUDICAO:
                    human.mfltLobosTemporais = DoCalculaConstante(human.mfltLobosTemporais);
                    break;
                case DEV_CEREBRO_SENSOR:
                    human.mfltLobosParietais = DoCalculaConstante(human.mfltLobosParietais);
                    break;
                case DEV_ESTABILIDADE_EMOCIONAL:
                    human.mfltInstabilidadeEmocional = DoCalculaConstante(human.mfltInstabilidadeEmocional);
                    break;
                case DEV_ESTROVERSAO:
                    human.mfltExtroversao = DoCalculaConstante(human.mfltExtroversao);
                    break;
                case DEV_AGRABILIDADE:
                    human.mfltAgradabilidade = DoCalculaConstante(human.mfltAgradabilidade);
                    break;
                case DEV_CONSCIENCIABILIDADE:
                    human.mfltConsciencialidade = DoCalculaConstante(human.mfltConsciencialidade);
                    break;
                case DEV_AVENTUREIRO:
                    human.mfltAberturaExperiencia = DoCalculaConstante(human.mfltAberturaExperiencia);
                    break;
                case ALTERA_ENERGIA:
                    human.mfltEnergia = DoCalculaConstante(human.mfltEnergia);
                    break;
                case ALTERA_FELICIDADE:
                    human.mfltFelicidade = DoCalculaConstante(human.mfltFelicidade);
                    break;
                case ALTERA_FOME:
                    human.mfltFome = DoCalculaConstante(human.mfltFome);
                    break;
                case ALTERA_INTELIGENCIA:
                    human.mfltInteligencia = DoCalculaConstante(human.mfltInteligencia);
                    break;
                case ALTERA_SAUDE:
                    human.mfltSaude = DoCalculaConstante(human.mfltSaude);
                    break;
                case ALTERA_BELEZA:
                    human.mfltBeleza = DoCalculaConstante(human.mfltBeleza);
                    break;
                case ALTERA_CONSCIENCIA:
                    human.mfltConsciencia = DoCalculaConstante(human.mfltConsciencia);
                    break;
                case DEV_PROF_LUTA_COPORTAL:
                    human.mfltProfLutaCorporal = DoCalculaConstante(human.mfltProfLutaCorporal);
                    break;
                case DEV_PROF_ARMA_BRANCA:
                    human.mfltProfArmasBrancas = DoCalculaConstante(human.mfltProfArmasBrancas);
                    break;
                case DEV_PROF_ARMA_FOGO:
                    human.mfltProfArmasFogo = DoCalculaConstante(human.mfltProfArmasFogo);
                    break;
                case DEV_PROF_CARRO:
                    human.mfltProfCarros = DoCalculaConstante(human.mfltProfCarros);
                    break;
                case DEV_PROF_MOTOS:
                    human.mfltProfMotos = DoCalculaConstante(human.mfltProfMotos);
                    break;
                case DEV_PROF_TECNOLOGIA:
                    human.mfltProfTecnologia = DoCalculaConstante(human.mfltProfTecnologia);
                    break;
                case DEV_PROF_SOCIAL:
                    human.mfltProfSocial = DoCalculaConstante(human.mfltProfSocial);
                    break;
                case DEV_PROF_ARTISTICA:
                    human.mfltProfArtistica = DoCalculaConstante(human.mfltProfArtistica);
                    break;
                case DEV_PROF_MUSICAL:
                    human.mfltProfMusical = DoCalculaConstante(human.mfltProfMusical);
                    break;
                case DEV_PROF_MATEMATICA:
                    human.mfltProfMatematica = DoCalculaConstante(human.mfltProfMatematica);
                    break;
                case DEV_PROF_PESQUISA:
                    human.mfltProfPesquisa = DoCalculaConstante(human.mfltProfPesquisa);
                    break;
                case DEV_PROF_ESPACIAL:
                    human.mfltProfEspacial = DoCalculaConstante(human.mfltProfEspacial);
                    break;
                case TENDENCIA_TRAPACA:
                    human.mfltTendTrapaca = DoCalculaConstante(human.mfltTendTrapaca);
                    break;
                case TENDENCIA_ROUBO:
                    human.mfltTendRoubo = DoCalculaConstante(human.mfltTendRoubo);
                    break;
                case TENDENCIA_DROGAS_LEVES:
                    human.mfltTendDrogasLeves = DoCalculaConstante(human.mfltTendDrogasLeves);
                    break;
                case TENDENCIA_DROGAS_PESADAS:
                    human.mfltTendDrogasPesadas = DoCalculaConstante(human.mfltTendDrogasPesadas);
                    break;
                case TENDENCIA_ESTUDAR:
                    human.mfltTendEstudar = DoCalculaConstante(human.mfltTendEstudar);
                    break;
                case TENDENCIA_FESTA:
                    human.mfltTendFesta = DoCalculaConstante(human.mfltTendFesta);
                    break;
                case TENDENCIA_SUICIDIO:
                    human.mfltTendSuicidio = DoCalculaConstante(human.mfltTendSuicidio);
                    break;
                case TENDENCIA_DECISOES_EMOCIONAIS:
                    human.mfltTendDecisaoEmocional = DoCalculaConstante(human.mfltTendDecisaoEmocional);
                    break;
                case TENDENCIA_PREGUICA:
                    mfltTendPreguica = DoCalculaConstante(human.mfltTendPreguica);
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
