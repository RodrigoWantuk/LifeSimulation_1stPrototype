using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1stPrototype.Enumeradores
{
    public enum enumEfeitoAcao
    {
        // Lista de tipos de efeito que uma ação que podem causar:

        // Pilares do conhecimento humano
        DEV_PILAR_HUMANO,
        DEV_PILAR_EMPIRICO,
        DEV_PILAR_FILOSOFICO,
        DEV_PILAR_TEOLOGICO,
        DEV_PILAR_CIENTIFICO,

        // Areas de Estudo
        ESTUDO_EXATAS,
        ESTUDO_BIOLOGICAS,
        ESTUDO_ENGENHARIAS,
        ESTUDO_SAUDE,
        ESTUDO_AGRARIA,
        ESTUDO_SOCIAIS,
        ESTUDO_HUMANAS,
        ESTUDO_LINGUISTICA,

        // Desenvolvimento cerebral
        DEV_CEREBRO_MOTOR,
        DEV_CEREBRO_PRECISAO,
        DEV_CEREBRO_VISAO,
        DEV_CEREBRO_AUDICAO,
        DEV_CEREBRO_SENSOR,
        DEV_ESTABILIDADE_EMOCIONAL,
        DEV_ESTROVERSAO,
        DEV_AGRABILIDADE,
        DEV_CONSCIENCIABILIDADE,
        DEV_AVENTUREIRO,

        // Altera fatores instantaneos do humano
        ALTERA_ENERGIA,
        ALTERA_FELICIDADE,
        ALTERA_FOME,
        ALTERA_INTELIGENCIA,
        ALTERA_SAUDE,
        ALTERA_BELEZA,
        ALTERA_CONSCIENCIA,

        // Proeficiencias, quao bem executa um determinado tipo de ações
        DEV_PROF_LUTA_COPORTAL,
        DEV_PROF_ARMA_BRANCA,
        DEV_PROF_ARMA_FOGO,
        DEV_PROF_CARRO,
        DEV_PROF_MOTOS,
        DEV_PROF_TECNOLOGIA,
        DEV_PROF_SOCIAL,
        DEV_PROF_ARTISTICA,
        DEV_PROF_MUSICAL,
        DEV_PROF_MATEMATICA,
        DEV_PROF_PESQUISA,
        DEV_PROF_ESPACIAL,

        // Informações para IA
        TENDENCIA_TRAPACA,
        TENDENCIA_ROUBO,
        TENDENCIA_DROGAS_LEVES,
        TENDENCIA_DROGAS_PESADAS,
        TENDENCIA_ESTUDAR,
        TENDENCIA_FESTA,
        TENDENCIA_SUICIDIO,
        TENDENCIA_DECISOES_EMOCIONAIS,
        TENDENCIA_PREGUICA
    }
}
