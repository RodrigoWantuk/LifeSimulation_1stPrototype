using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1stPrototype.Enumeradores;
using _1stPrototype.Classes.Relacionamentos;

namespace _1stPrototype.Classes.Objetos
{
    public class Human
    {
        private int mintDiaNascimento; // Dia do Nascimento.
        private int mintIdade; // Idade atual.
        private enumSexo msxSexo; // Sexo do Humano.

        private DNA mdnaGenoma; // Código DNA que rege o individuo (funções principais).

        private String mstrNome;
        private String mstrSobrenome;

        private Human mhmnPai; // Humano Pai.
        private Human mhmnMae; // Humano Mãe.
        private Human mhmnPaiBiologico; // Humano Pai Biologico.
        private Human mhmnMaeBiologica; // Humano Mãe Biologico.
        private bool mblnAdotado; // Indica se foi Adotado ou é Biológico.

        private enumOrientacaoSexual morsOrientacaoSexual; // Indica a orientação sexual.

        private Human mhmnParceiroAtual; // Humano Parceiro Atual. Pode ser Null.
        private List<RelacionamentoHumano> mlrlRelacionamentos; // Lista dos Relacionamentos.
        private List<Human> mlhmFilhos; // Lista dos Filhos.

        private int mintSaldoDinheiro; // Saldo total em conta.

        // Pilares do Conhecimento
        private float mfltHumano; // Experiencia Humana do Ser. Pensamentos, Invencoes, Criacoes.
        private float mfltEmpirico; // Conhecimento do mundo, da realidade diaria, sem envolver a teoria cientifica.
        private float mfltFilosofico; // Reflexão do homem das suas ações do dia-a-dia.
        private float mfltTeologico; // Perguntas que só a fé podem explicar.
        private float mfltCientifico; // Conhecimento passivel de verificação. Usa métodos, leis, etc.

        // Áreas do Conhecimento
        private float mfltCienciasExatas; // Matematica, Astronomia, Fisica, etc;
        private float mfltCienciasBiologicas; // Genetica, Zoologia, Oceanografia, etc;
        private float mfltEngenharias; // Engenharias;
        private float mfltCienciasSaude; // Medicina, Nutrição, Farmacia, Enfermagem, etc;
        private float mfltCienciasAgrarias; // Agronomia, Zootecnia, Medicina Veterinaria, etc;
        private float mfltCienciasSociais; // Direito, Administracao, Economia, Arquitetura, etc;
        private float mfltCienciasHumanas; // Filosofia, Sociologia, Historia, etc;
        private float mfltLinguistica; // Letras, Artes, etc;

        // Áreas do Cerebro - Lobos, Cortex
        private float mfltCortexMotor; // Lobo Frontal, Movimentos.
        private float mfltCortexPreFrontal; // Lobo Frontal, Precisao e velocidade de movimentos.
        private float mfltLobosOccipitais; // Lobos Occipitais, Visão.
        private float mfltLobosTemporais; // Audição.
        private float mfltLobosParietais; // Sensações, sentidos como tato, dor, calor, labios, lingua, etc.

        // Big Five - Fatores da Personalidade
        private float mfltInstabilidadeEmocional; // Estabilidade Emocional do Individuo. Tendencia a Raiva, Depressão.
        private float mfltExtroversao; // Procura de Emoções Positivas e Companhia de Outros. Cheios de Energia.
        private float mfltAgradabilidade; // Tendencia a ser compassivo ao inves de antagonista a ideias. Preocupado com Harmonia Social.
        private float mfltConsciencialidade; // Autodisciplina, Orientação a Deveres e Objetivos.
        private float mfltAberturaExperiencia; // Interesse por ideias fora do comum, emoção, aventuras, curiosidade, experiencias. Pessoas Imaginativas.

        // Parametros Humanos
        private float mfltEnergia;  // Energia para atividades, trabalho, estudo.
        private float mfltFelicidade; // Felicidade geral. Indica depressão, desanimo.
        private float mfltFome; // Fome. Contribui para Energia, Felicidade e em casos extremos para saúde.
        private float mfltInteligencia; // Overall dos atributos de inteligencia, resumo para o usuário.
        private float mfltSaude; // Saúde. Indica como o individuo tem cuidado da propria saude, presença de doenças, condicionamento fisico, etc.
        private float mfltBeleza; // Aparencia Visual. Atributos gerais de beleza.

        // Proeficiencias
        private float mfltProfLutaCorporal; // Proeficiencia a luta desarmada.
        private float mfltProfArmasBrancas; // Proeficiencia a luta com armas brancas.
        private float mfltProfArmasFogo; // Proeficiencia a uso de armas de fogo.
        private float mfltProfCarros; // Proeficiencia a direção de automóveis.
        private float mfltProfMotos; // Proeficiencia a direção de motos.
        private float mfltProfTecnologia; // Proeficiancia ao uso de tecnologia.
        private float mfltProfSocial; // Proeficiencia a interações sociais.
        private float mfltProfArtistica; // Proeficiencia a trabalhos artisticos.
        private float mfltProfMusical; // Proeficiencia a trabalhos musicais.
        private float mfltProfMatematica; // Proeficiencia a matematica e lógica.
        private float mfltProfPesquisa; // Proeficiencia a pesquisa, a escrita, ao conhecimento.
        private float mfltProfEspacial; // Proeficiencia a noção espacial e leis que o regem.

        // Tendencias - Fatores para IA
        private float mfltTendTrapaca; // Tendencia a trapacear.
        private float mfltTendRoubo; // Tendencia a roubar.
        private float mfltTendDrogasLeves; // Tendencia ao uso de cigarro / alcool.
        private float mfltTendDrogasPesadas; // Tendencia ao uso de drogas ilícitas.
        private float mfltTendEstudar; // Tendencia a permanecer estudando.
        private float mfltTendFesta; // Tendencia a sair com amigos, festas, etc.
        private float mfltTendSuicidio; // Tendencia a cometer suicidio. Definir threshold para IA cometer suicidio.
        private float mfltTendDecisaoEmocional; // Tendencia a tomar decisões emocionais ao invés de lógicas.
        private float mfltTendPreguica; // Tendencia a preguiça, procrastinação.

        public static Human doBorn(Human hmnPai, Human hmnMae, String name, enumSexo sexo, bool surnamePai)
        {
            Human newHuman = new Human();

            newHuman.mhmnPaiBiologico = hmnPai;
            newHuman.mhmnMaeBiologica = hmnMae;
            newHuman.mhmnPai = hmnPai;
            newHuman.mhmnMae = hmnMae;
            newHuman.mblnAdotado = false;
            newHuman.msxSexo = sexo;
            newHuman.mstrNome = name;

            if (surnamePai)
                newHuman.mstrSobrenome = hmnPai.mstrSobrenome;
            else
                newHuman.mstrSobrenome = hmnMae.mstrSobrenome;

            newHuman.mdnaGenoma = DNA.fundirGenoma(hmnPai.mdnaGenoma, hmnMae.mdnaGenoma);
            newHuman.morsOrientacaoSexual = enumOrientacaoSexual.Heterossexual;
            newHuman.mintIdade = 0;
            //TODO: newHuman.mintDiaNascimento = xx; // Preencher!!

            newHuman.mhmnParceiroAtual = null;
            newHuman.mlrlRelacionamentos = new List<RelacionamentoHumano>();
            newHuman.mlhmFilhos = new List<Human>();

            newHuman.mintSaldoDinheiro = 0;

            newHuman.mfltHumano = 0.01f; // Rescem nascido, 1% de conhecimento da realidade humana.
            newHuman.mfltEmpirico = 0.01f; // Rescem nascido, 1% de conhecimento empirico, experienciado.
            newHuman.mfltFilosofico = 0.00f; // Rescem nascido, sem capacidade de conhecimento filosófico.
            newHuman.mfltTeologico = 0.00f; // Rescem nascido, sem capacidade de conhecimento teológico.
            newHuman.mfltCientifico = 0.00f; // Rescem nascido, sem capacidade de conhecimento cientifico.

            newHuman.mfltCienciasExatas = 0.00f; // Rescem nascido, sem capacidade deste tipo de conhecimento.
            newHuman.mfltCienciasBiologicas = 0.00f; // Rescem nascido, sem capacidade deste tipo de conhecimento.
            newHuman.mfltEngenharias = 0.00f; // Rescem nascido, sem capacidade deste tipo de conhecimento.
            newHuman.mfltCienciasSaude = 0.00f; // Rescem nascido, sem capacidade deste tipo de conhecimento.
            newHuman.mfltCienciasAgrarias = 0.00f; // Rescem nascido, sem capacidade deste tipo de conhecimento.
            newHuman.mfltCienciasSociais = 0.00f; // Rescem nascido, sem capacidade deste tipo de conhecimento.
            newHuman.mfltCienciasHumanas = 0.00f; // Rescem nascido, sem capacidade deste tipo de conhecimento.
            newHuman.mfltLinguistica = 0.00f; // Rescem nascido, sem capacidade deste tipo de conhecimento.

            newHuman.mfltCortexMotor = 0.07f * (float)DNA.obtemInfluenciadorAtletico(newHuman.mdnaGenoma); // Inicia valor default com influenciador genético.
            newHuman.mfltCortexPreFrontal = 0.01f * (float)DNA.obtemInfluenciadorAtletico(newHuman.mdnaGenoma); // Inicia valor default com influenciador genético.
            newHuman.mfltLobosOccipitais = 0.02f * (float)DNA.obtemInfluenciadorDomArtistico(newHuman.mdnaGenoma); // Inicia valor default com influenciador genético.
            newHuman.mfltLobosTemporais = 0.03f * (float)DNA.obtemInfluenciadorDomArtistico(newHuman.mdnaGenoma); // Inicia valor default com influenciador genético.
            newHuman.mfltLobosParietais = 0.05f * (float)DNA.obtemInfluenciadorSaude(newHuman.mdnaGenoma); // Inicia valor default com influenciador genético.

            newHuman.mfltInstabilidadeEmocional = (float)Human.geraInstabilidadeEmocionalNascimento(newHuman.mdnaGenoma); // Inicia valor default com influenciador genético.
            newHuman.mfltExtroversao = (float)Human.geraExtroversaoNascimento(newHuman.mdnaGenoma); // Inicia valor default com influenciador genético.
            newHuman.mfltAgradabilidade = (float)Human.geraAgrabilidadeNascimento(newHuman.mdnaGenoma); // Inicia valor default com influenciador genético.
            newHuman.mfltConsciencialidade = (float)Human.geraConsciencialidadeNascimento(newHuman.mdnaGenoma); // Inicia valor default com influenciador genético.
            newHuman.mfltAberturaExperiencia = (float)Human.geraAberturaExperienciaNascimento(newHuman.mdnaGenoma); // Inicia valor default com influenciador genético.

            newHuman.mfltEnergia = 1.00f;  // Bebes cheios de energia!
            newHuman.mfltFelicidade = (float)Human.geraFelicidadeNascimento(newHuman.mdnaGenoma); // Varios Fatores, Genetica + Saude + Natureza.
            newHuman.mfltFome = 0.50f + (new Random().Next(0, 20) / 100); // Bebes nascem com certa fome...
            newHuman.mfltInteligencia = (float)Human.geraOverallInteligenciaNascimento(newHuman.mdnaGenoma); // Varios Fatores Geneticos + Saude + Natureza.
            newHuman.mfltSaude = 0.50f + (float)(DNA.obtemInfluenciadorSaude(newHuman.mdnaGenoma) * (0.3 / 1.9)) + (new Random().Next(0, 21) / 100); // Saúde. Default + Genetico + Natureza.
            newHuman.mfltBeleza = 0.40f + (float)(DNA.obtemInfluenciadorBeleza(newHuman.mdnaGenoma) * (0.4 / 1.9)) + (new Random().Next(0, 21) / 100); // Bebes são bonitos. Aplica Genetica + Naturza.

            // ------- EM DESENVOLVIMENTO
            // TODO: TERMINAR.


            return newHuman;
        }

        private static double geraOverallInteligenciaNascimento(DNA dna)
        {
            return 0.01 +
                (DNA.obtemInfluenciadorCriativo(dna) * (0.01 / 1.9)) +
                (DNA.obtemInfluenciadorDedicacao(dna) * (0.01 / 1.9)) +
                (DNA.obtemInfluenciadorDomArtistico(dna) * (0.01 / 1.9)) +
                (DNA.obtemInfluenciadorEstudo(dna) * (0.02 / 1.9)) +
                (DNA.obtemInfluenciadorFacilidadeAprender(dna) * (0.01 / 1.9)) +
                (new Random().Next(0, 10) / 1000); // Fator Natureza.
        }

        private static double geraFelicidadeNascimento(DNA dna)
        {
            return 0.40 +
                (DNA.obtemInfluenciadorSaude(dna) * (0.3 / 1.9)) +
                (DNA.obtemInfluenciadorEstabilidadeEmocional(dna) * (0.1 / 1.9)) +
                (DNA.obtemInfluenciadorSocial(dna) * (0.1 / 1.9)) +
                (new Random().Next(0, 10) / 100); // Fator Natureza.
        }

        private static double geraInstabilidadeEmocionalNascimento(DNA dna)
        {
            // Pendente 0,09 de influencia de criação. - 30%
            return (DNA.obtemInfluenciadorEstabilidadeEmocional(dna) * (0.15 / 1.9)) + // 50%
                (DNA.obtemInfluenciadorViolento(dna) * (0.06 / 1.9)); // 20%
        }
        private static double geraExtroversaoNascimento(DNA dna)
        {
            // Pendente 0.075 de influencia de criação. - 25%
            return (DNA.obtemInfluenciadorSocial(dna) * (0.075 / 1.9)) + // 25%
                (DNA.obtemInfluenciadorBeleza(dna) * (0.03 / 1.9)) + // 10%
                (DNA.obtemInfluenciadorEstabilidadeEmocional(dna) * (0.03 / 1.9)) + // 10%
                (0.03 - (DNA.obtemInfluenciadorViolento(dna) * (0.03 / 1.9))) + // -10%
                (0.06 - (DNA.obtemInfluenciadorDepressao(dna) * (0.06 / 1.9))); // -20%
        }
        private static double geraAgrabilidadeNascimento(DNA dna)
        {
            // Pendente 0.06 de influencia de criação. - 20%
            return (DNA.obtemInfluenciadorDepressao(dna) * (0.045 / 1.9)) + // 15%
                (0.12 - (DNA.obtemInfluenciadorViolento(dna) * (0.12 / 1.9))) + // -40%
                (0.045 - (DNA.obtemInfluenciadorCriminalidade(dna) * (0.045 / 1.9))) + // -15%
                (0.03 - (DNA.obtemInfluenciadorBeleza(dna) * (0.03 / 1.9))); // -10%
        }
        private static double geraConsciencialidadeNascimento(DNA dna)
        {
            // Pendente 0.12 de influencia de criação. - 40%
            return (DNA.obtemInfluenciadorEstudo(dna) * (0.06 / 1.9)) + // 20%
                (DNA.obtemInfluenciadorDedicacao(dna) * (0.09 / 1.9)) + // 30%
                (0.03 - (DNA.obtemInfluenciadorDrogas(dna) * (0.03 / 1.9))); // -10%
        }
        private static double geraAberturaExperienciaNascimento(DNA dna)
        {
            // Pendente 0.06 de influencia de criação. - 20%
            return (DNA.obtemInfluenciadorCriativo(dna) * (0.12 / 1.9)) + // 40%
                (DNA.obtemInfluenciadorAtletico(dna) * (0.03 / 1.9)) + // 10%
                (DNA.obtemInfluenciadorLongevidade(dna) * (0.03 / 1.9)) + // 10%
                (DNA.obtemInfluenciadorSocial(dna) * (0.06 / 1.9)); // 20%
        }
    }
}
