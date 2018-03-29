using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1stPrototype.Enumeradores;

namespace _1stPrototype.Classes.Objetos
{
    class DNA
    {
        private static Random randomizer = new Random();

        private enumGene mgneCriminalidadeNv1;
        private enumGene mgneCriminalidadeNv2;
        private enumGene mgneCriminalidadeNv3;

        private enumGene mgneEstudoNv1;
        private enumGene mgneEstudoNv2;
        private enumGene mgneEstudoNv3;

        private enumGene mgneFacilidadeAprenderNv1;
        private enumGene mgneFacilidadeAprenderNv2;
        private enumGene mgneFacilidadeAprenderNv3;

        private enumGene mgneDomArtisticoNv1;
        private enumGene mgneDomArtisticoNv2;
        private enumGene mgneDomArtisticoNv3;

        private enumGene mgneSaudeNv1;
        private enumGene mgneSaudeNv2;
        private enumGene mgneSaudeNv3;

        private enumGene mgneAtleticoNv1;
        private enumGene mgneAtleticoNv2;
        private enumGene mgneAtleticoNv3;

        private enumGene mgneLongevidadeNv1;
        private enumGene mgneLongevidadeNv2;
        private enumGene mgneLongevidadeNv3;

        private enumGene mgneReligioso;
        private enumGene mgneDepressao;

        private enumGene mgneTendenciaDrogasNv1;
        private enumGene mgneTendenciaDrogasNv2;
        private enumGene mgneTendenciaDrogasNv3;

        private enumGene mgneEstabilidadeEmocionalNv1;
        private enumGene mgneEstabilidadeEmocionalNv2;
        private enumGene mgneEstabilidadeEmocionalNv3;

        private enumGene mgneDedicacaoNv1;
        private enumGene mgneDedicacaoNv2;
        private enumGene mgneDedicacaoNv3;

        private enumGene mgneBelezaNv1;
        private enumGene mgneBelezaNv2;
        private enumGene mgneBelezaNv3;

        private enumGene mgneDomTecnologicoNv1;
        private enumGene mgneDomTecnologicoNv2;
        private enumGene mgneDomTecnologicoNv3;

        private enumGene mgneDomSocialNv1;
        private enumGene mgneDomSocialNv2;
        private enumGene mgneDomSocialNv3;

        private enumGene mgneCriativoNv1;
        private enumGene mgneCriativoNv2;
        private enumGene mgneCriativoNv3;

        private enumGene mgneFertilidadeNv1;
        private enumGene mgneFertilidadeNv2;
        private enumGene mgneFertilidadeNv3;

        private enumGene mgneViolentoNv1;
        private enumGene mgneViolentoNv2;
        private enumGene mgneViolentoNv3;



        public static DNA fundirGenoma(DNA genomaA, DNA genomaB)
        {
            DNA newGenoma = new DNA();

            newGenoma.mgneCriminalidadeNv1 = DNA.processaGene(genomaA.mgneCriminalidadeNv1, genomaB.mgneCriminalidadeNv1);
            newGenoma.mgneCriminalidadeNv2 = DNA.processaGene(genomaA.mgneCriminalidadeNv2, genomaB.mgneCriminalidadeNv2);
            newGenoma.mgneCriminalidadeNv3 = DNA.processaGene(genomaA.mgneCriminalidadeNv3, genomaB.mgneCriminalidadeNv3);

            newGenoma.mgneEstudoNv1 = DNA.processaGene(genomaA.mgneEstudoNv1, genomaB.mgneEstudoNv1);
            newGenoma.mgneEstudoNv2 = DNA.processaGene(genomaA.mgneEstudoNv2, genomaB.mgneEstudoNv2);
            newGenoma.mgneEstudoNv3 = DNA.processaGene(genomaA.mgneEstudoNv3, genomaB.mgneEstudoNv3);

            newGenoma.mgneFacilidadeAprenderNv1 = DNA.processaGene(genomaA.mgneFacilidadeAprenderNv1, genomaB.mgneFacilidadeAprenderNv1);
            newGenoma.mgneFacilidadeAprenderNv2 = DNA.processaGene(genomaA.mgneFacilidadeAprenderNv2, genomaB.mgneFacilidadeAprenderNv2);
            newGenoma.mgneFacilidadeAprenderNv3 = DNA.processaGene(genomaA.mgneFacilidadeAprenderNv3, genomaB.mgneFacilidadeAprenderNv3);

            newGenoma.mgneDomArtisticoNv1 = DNA.processaGene(genomaA.mgneDomArtisticoNv1, genomaB.mgneDomArtisticoNv1);
            newGenoma.mgneDomArtisticoNv2 = DNA.processaGene(genomaA.mgneDomArtisticoNv2, genomaB.mgneDomArtisticoNv2);
            newGenoma.mgneDomArtisticoNv3 = DNA.processaGene(genomaA.mgneDomArtisticoNv3, genomaB.mgneDomArtisticoNv3);

            newGenoma.mgneSaudeNv1 = DNA.processaGene(genomaA.mgneSaudeNv1, genomaB.mgneSaudeNv1);
            newGenoma.mgneSaudeNv2 = DNA.processaGene(genomaA.mgneSaudeNv2, genomaB.mgneSaudeNv2);
            newGenoma.mgneSaudeNv3 = DNA.processaGene(genomaA.mgneSaudeNv3, genomaB.mgneSaudeNv3);

            newGenoma.mgneAtleticoNv1 = DNA.processaGene(genomaA.mgneAtleticoNv1, genomaB.mgneAtleticoNv1);
            newGenoma.mgneAtleticoNv2 = DNA.processaGene(genomaA.mgneAtleticoNv2, genomaB.mgneAtleticoNv2);
            newGenoma.mgneAtleticoNv3 = DNA.processaGene(genomaA.mgneAtleticoNv3, genomaB.mgneAtleticoNv3);

            newGenoma.mgneLongevidadeNv1 = DNA.processaGene(genomaA.mgneLongevidadeNv1, genomaB.mgneLongevidadeNv1);
            newGenoma.mgneLongevidadeNv2 = DNA.processaGene(genomaA.mgneLongevidadeNv2, genomaB.mgneLongevidadeNv2);
            newGenoma.mgneLongevidadeNv3 = DNA.processaGene(genomaA.mgneLongevidadeNv3, genomaB.mgneLongevidadeNv3);

            newGenoma.mgneReligioso = DNA.processaGene(genomaA.mgneReligioso, genomaB.mgneReligioso);
            newGenoma.mgneDepressao = DNA.processaGene(genomaA.mgneDepressao, genomaB.mgneDepressao);

            newGenoma.mgneTendenciaDrogasNv1 = DNA.processaGene(genomaA.mgneTendenciaDrogasNv1, genomaB.mgneTendenciaDrogasNv1);
            newGenoma.mgneTendenciaDrogasNv2 = DNA.processaGene(genomaA.mgneTendenciaDrogasNv2, genomaB.mgneTendenciaDrogasNv2);
            newGenoma.mgneTendenciaDrogasNv3 = DNA.processaGene(genomaA.mgneTendenciaDrogasNv3, genomaB.mgneTendenciaDrogasNv3);

            newGenoma.mgneEstabilidadeEmocionalNv1 = DNA.processaGene(genomaA.mgneEstabilidadeEmocionalNv1, genomaB.mgneEstabilidadeEmocionalNv1);
            newGenoma.mgneEstabilidadeEmocionalNv2 = DNA.processaGene(genomaA.mgneEstabilidadeEmocionalNv2, genomaB.mgneEstabilidadeEmocionalNv2);
            newGenoma.mgneEstabilidadeEmocionalNv3 = DNA.processaGene(genomaA.mgneEstabilidadeEmocionalNv3, genomaB.mgneEstabilidadeEmocionalNv3);

            newGenoma.mgneDedicacaoNv1 = DNA.processaGene(genomaA.mgneDedicacaoNv1, genomaB.mgneDedicacaoNv1);
            newGenoma.mgneDedicacaoNv2 = DNA.processaGene(genomaA.mgneDedicacaoNv2, genomaB.mgneDedicacaoNv2);
            newGenoma.mgneDedicacaoNv3 = DNA.processaGene(genomaA.mgneDedicacaoNv3, genomaB.mgneDedicacaoNv3);

            newGenoma.mgneBelezaNv1 = DNA.processaGene(genomaA.mgneBelezaNv1, genomaB.mgneBelezaNv1);
            newGenoma.mgneBelezaNv2 = DNA.processaGene(genomaA.mgneBelezaNv2, genomaB.mgneBelezaNv2);
            newGenoma.mgneBelezaNv3 = DNA.processaGene(genomaA.mgneBelezaNv3, genomaB.mgneBelezaNv3);

            newGenoma.mgneDomTecnologicoNv1 = DNA.processaGene(genomaA.mgneDomTecnologicoNv1, genomaB.mgneDomTecnologicoNv1);
            newGenoma.mgneDomTecnologicoNv2 = DNA.processaGene(genomaA.mgneDomTecnologicoNv2, genomaB.mgneDomTecnologicoNv2);
            newGenoma.mgneDomTecnologicoNv3 = DNA.processaGene(genomaA.mgneDomTecnologicoNv3, genomaB.mgneDomTecnologicoNv3);

            newGenoma.mgneDomSocialNv1 = DNA.processaGene(genomaA.mgneDomSocialNv1, genomaB.mgneDomSocialNv1);
            newGenoma.mgneDomSocialNv2 = DNA.processaGene(genomaA.mgneDomSocialNv2, genomaB.mgneDomSocialNv2);
            newGenoma.mgneDomSocialNv3 = DNA.processaGene(genomaA.mgneDomSocialNv3, genomaB.mgneDomSocialNv3);

            newGenoma.mgneCriativoNv1 = DNA.processaGene(genomaA.mgneCriativoNv1, genomaB.mgneCriativoNv1);
            newGenoma.mgneCriativoNv2 = DNA.processaGene(genomaA.mgneCriativoNv2, genomaB.mgneCriativoNv2);
            newGenoma.mgneCriativoNv3 = DNA.processaGene(genomaA.mgneCriativoNv3, genomaB.mgneCriativoNv3);

            newGenoma.mgneFertilidadeNv1 = DNA.processaGene(genomaA.mgneFertilidadeNv1, genomaB.mgneFertilidadeNv1);
            newGenoma.mgneFertilidadeNv2 = DNA.processaGene(genomaA.mgneFertilidadeNv2, genomaB.mgneFertilidadeNv2);
            newGenoma.mgneFertilidadeNv3 = DNA.processaGene(genomaA.mgneFertilidadeNv3, genomaB.mgneFertilidadeNv3);

            newGenoma.mgneViolentoNv1 = DNA.processaGene(genomaA.mgneViolentoNv1, genomaB.mgneViolentoNv1);
            newGenoma.mgneViolentoNv2 = DNA.processaGene(genomaA.mgneViolentoNv2, genomaB.mgneViolentoNv2);
            newGenoma.mgneViolentoNv3 = DNA.processaGene(genomaA.mgneViolentoNv3, genomaB.mgneViolentoNv3);

            return newGenoma;
        }

        private static enumGene processaGene(enumGene geneA, enumGene geneB)
        {
            // Aplica lei de Mendel:
            if (geneA == enumGene.AA && geneB == enumGene.AA)
                return enumGene.AA;

            if (geneA == enumGene.aa && geneB == enumGene.aa)
                return enumGene.aa;

            if ((geneA == enumGene.AA && geneB == enumGene.aa) || (geneA == enumGene.aa && geneB == enumGene.AA))
                return enumGene.Aa;

            int random = randomizer.Next(0, 4); // Inclui 0, Exclui 4. Faixa: [0-3]. Suficiente para obter 25%.

            if ((geneA == enumGene.AA && geneB == enumGene.Aa) || (geneA == enumGene.Aa && geneB == enumGene.AA))
            {
                if (random >= 2)
                    return enumGene.AA;

                return enumGene.Aa;
            }

            if ((geneA == enumGene.Aa && geneB == enumGene.aa) || (geneA == enumGene.aa && geneB == enumGene.Aa))
            {
                if (random >= 2)
                    return enumGene.Aa;

                return enumGene.aa;
            }

            if (geneA == enumGene.Aa && geneB == enumGene.Aa)
            {
                if (random == 0)
                    return enumGene.AA;

                if (random == 1)
                    return enumGene.aa;

                return enumGene.Aa;
            }

            // The code should never reach this point.
            return enumGene.Aa;

        }

        public static double obtemInfluenciadorGenetico(enumGene gene)
        {
            if (gene == enumGene.aa)
                return 0.00;

            if (gene == enumGene.Aa)
                return 0.50;

            //if (gene == enumGene.AA)
            return 1.00;
        }

        public static double obtemInfluenciadorCriminalidade(DNA dna)
        {
            double influenciador = 0.40;

            if (dna.mgneCriminalidadeNv1 == enumGene.AA)
                influenciador += 0.35;

            if (dna.mgneCriminalidadeNv1 == enumGene.Aa)
                influenciador += 0.10;

            if (dna.mgneCriminalidadeNv2 == enumGene.AA)
                influenciador += 0.50;

            if (dna.mgneCriminalidadeNv2 == enumGene.Aa)
                influenciador += 0.15;

            if (dna.mgneCriminalidadeNv3 == enumGene.AA)
                influenciador += 0.70;

            if (dna.mgneCriminalidadeNv3 == enumGene.Aa)
                influenciador += 0.20;

            return influenciador;
        }

        public static double obtemInfluenciadorEstudo(DNA dna)
        {
            double influenciador = 0.40;

            if (dna.mgneEstudoNv1 == enumGene.AA)
                influenciador += 0.35;

            if (dna.mgneEstudoNv1 == enumGene.Aa)
                influenciador += 0.10;

            if (dna.mgneEstudoNv2 == enumGene.AA)
                influenciador += 0.50;

            if (dna.mgneEstudoNv2 == enumGene.Aa)
                influenciador += 0.15;

            if (dna.mgneEstudoNv3 == enumGene.AA)
                influenciador += 0.70;

            if (dna.mgneEstudoNv3 == enumGene.Aa)
                influenciador += 0.20;

            return influenciador;
        }

        public static double obtemInfluenciadorFacilidadeAprender(DNA dna)
        {
            double influenciador = 0.40;

            if (dna.mgneFacilidadeAprenderNv1 == enumGene.AA)
                influenciador += 0.35;

            if (dna.mgneFacilidadeAprenderNv1 == enumGene.Aa)
                influenciador += 0.10;

            if (dna.mgneFacilidadeAprenderNv2 == enumGene.AA)
                influenciador += 0.50;

            if (dna.mgneFacilidadeAprenderNv2 == enumGene.Aa)
                influenciador += 0.15;

            if (dna.mgneFacilidadeAprenderNv3 == enumGene.AA)
                influenciador += 0.70;

            if (dna.mgneFacilidadeAprenderNv3 == enumGene.Aa)
                influenciador += 0.20;

            return influenciador;
        }

        public static double obtemInfluenciadorDomArtistico(DNA dna)
        {
            double influenciador = 0.40;

            if (dna.mgneDomArtisticoNv1 == enumGene.AA)
                influenciador += 0.35;

            if (dna.mgneDomArtisticoNv1 == enumGene.Aa)
                influenciador += 0.10;

            if (dna.mgneDomArtisticoNv2 == enumGene.AA)
                influenciador += 0.50;

            if (dna.mgneDomArtisticoNv2 == enumGene.Aa)
                influenciador += 0.15;

            if (dna.mgneDomArtisticoNv3 == enumGene.AA)
                influenciador += 0.70;

            if (dna.mgneDomArtisticoNv3 == enumGene.Aa)
                influenciador += 0.20;

            return influenciador;
        }

        public static double obtemInfluenciadorSaude(DNA dna)
        {
            double influenciador = 0.40;

            if (dna.mgneSaudeNv1 == enumGene.AA)
                influenciador += 0.35;

            if (dna.mgneSaudeNv1 == enumGene.Aa)
                influenciador += 0.10;

            if (dna.mgneSaudeNv2 == enumGene.AA)
                influenciador += 0.50;
        
            if (dna.mgneSaudeNv2 == enumGene.Aa)
                influenciador += 0.15;

            if (dna.mgneSaudeNv3 == enumGene.AA)
                influenciador += 0.70;

            if (dna.mgneSaudeNv3 == enumGene.Aa)
                influenciador += 0.20;

            return influenciador;
        }

        public static double obtemInfluenciadorAtletico(DNA dna)
        {
            double influenciador = 0.40;

            if (dna.mgneAtleticoNv1 == enumGene.AA)
                influenciador += 0.35;

            if (dna.mgneAtleticoNv1 == enumGene.Aa)
                influenciador += 0.10;

            if (dna.mgneAtleticoNv2 == enumGene.AA)
                influenciador += 0.50;

            if (dna.mgneAtleticoNv2 == enumGene.Aa)
                influenciador += 0.15;

            if (dna.mgneAtleticoNv3 == enumGene.AA)
                influenciador += 0.70;

            if (dna.mgneAtleticoNv3 == enumGene.Aa)
                influenciador += 0.20;

            return influenciador;
        }

        public static double obtemInfluenciadorLongevidade(DNA dna)
        {
            double influenciador = 0.40;

            if (dna.mgneLongevidadeNv1 == enumGene.AA)
                influenciador += 0.35;

            if (dna.mgneLongevidadeNv1 == enumGene.Aa)
                influenciador += 0.10;

            if (dna.mgneLongevidadeNv2 == enumGene.AA)
                influenciador += 0.50;

            if (dna.mgneLongevidadeNv2 == enumGene.Aa)
                influenciador += 0.15;

            if (dna.mgneLongevidadeNv3 == enumGene.AA)
                influenciador += 0.70;

            if (dna.mgneLongevidadeNv3 == enumGene.Aa)
                influenciador += 0.20;

            return influenciador;
        }

        public static double obtemInfluenciadorDrogas(DNA dna)
        {
            double influenciador = 0.40;

            if (dna.mgneTendenciaDrogasNv1 == enumGene.AA)
                influenciador += 0.35;

            if (dna.mgneTendenciaDrogasNv1 == enumGene.Aa)
                influenciador += 0.10;

            if (dna.mgneTendenciaDrogasNv2 == enumGene.AA)
                influenciador += 0.50;

            if (dna.mgneTendenciaDrogasNv2 == enumGene.Aa)
                influenciador += 0.15;

            if (dna.mgneTendenciaDrogasNv3 == enumGene.AA)
                influenciador += 0.70;

            if (dna.mgneTendenciaDrogasNv3 == enumGene.Aa)
                influenciador += 0.20;

            return influenciador;
        }

        public static double obtemInfluenciadorEstabilidadeEmocional(DNA dna)
        {
            double influenciador = 0.40;

            if (dna.mgneEstabilidadeEmocionalNv1 == enumGene.AA)
                influenciador += 0.35;

            if (dna.mgneEstabilidadeEmocionalNv1 == enumGene.Aa)
                influenciador += 0.10;

            if (dna.mgneEstabilidadeEmocionalNv2 == enumGene.AA)
                influenciador += 0.50;

            if (dna.mgneEstabilidadeEmocionalNv2 == enumGene.Aa)
                influenciador += 0.15;

            if (dna.mgneEstabilidadeEmocionalNv3 == enumGene.AA)
                influenciador += 0.70;

            if (dna.mgneEstabilidadeEmocionalNv3 == enumGene.Aa)
                influenciador += 0.20;

            return influenciador;
        }

        public static double obtemInfluenciadorDedicacao(DNA dna)
        {
            double influenciador = 0.40;

            if (dna.mgneDedicacaoNv1 == enumGene.AA)
                influenciador += 0.35;

            if (dna.mgneDedicacaoNv1 == enumGene.Aa)
                influenciador += 0.10;

            if (dna.mgneDedicacaoNv2 == enumGene.AA)
                influenciador += 0.50;

            if (dna.mgneDedicacaoNv2 == enumGene.Aa)
                influenciador += 0.15;

            if (dna.mgneDedicacaoNv3 == enumGene.AA)
                influenciador += 0.70;

            if (dna.mgneDedicacaoNv3 == enumGene.Aa)
                influenciador += 0.20;

            return influenciador;
        }

        public static double obtemInfluenciadorBeleza(DNA dna)
        {
            double influenciador = 0.40;

            if (dna.mgneBelezaNv1 == enumGene.AA)
                influenciador += 0.35;

            if (dna.mgneBelezaNv1 == enumGene.Aa)
                influenciador += 0.10;

            if (dna.mgneBelezaNv2 == enumGene.AA)
                influenciador += 0.50;

            if (dna.mgneBelezaNv2 == enumGene.Aa)
                influenciador += 0.15;

            if (dna.mgneBelezaNv3 == enumGene.AA)
                influenciador += 0.70;

            if (dna.mgneBelezaNv3 == enumGene.Aa)
                influenciador += 0.20;

            return influenciador;
        }

        public static double obtemInfluenciadorTecnologico(DNA dna)
        {
            double influenciador = 0.40;

            if (dna.mgneDomTecnologicoNv1 == enumGene.AA)
                influenciador += 0.35;

            if (dna.mgneDomTecnologicoNv1 == enumGene.Aa)
                influenciador += 0.10;

            if (dna.mgneDomTecnologicoNv2 == enumGene.AA)
                influenciador += 0.50;

            if (dna.mgneDomTecnologicoNv2 == enumGene.Aa)
                influenciador += 0.15;

            if (dna.mgneDomTecnologicoNv3 == enumGene.AA)
                influenciador += 0.70;

            if (dna.mgneDomTecnologicoNv3 == enumGene.Aa)
                influenciador += 0.20;

            return influenciador;
        }

        public static double obtemInfluenciadorSocial(DNA dna)
        {
            double influenciador = 0.40;

            if (dna.mgneDomSocialNv1 == enumGene.AA)
                influenciador += 0.35;

            if (dna.mgneDomSocialNv1 == enumGene.Aa)
                influenciador += 0.10;

            if (dna.mgneDomSocialNv2 == enumGene.AA)
                influenciador += 0.50;

            if (dna.mgneDomSocialNv2 == enumGene.Aa)
                influenciador += 0.15;

            if (dna.mgneDomSocialNv3 == enumGene.AA)
                influenciador += 0.70;

            if (dna.mgneDomSocialNv3 == enumGene.Aa)
                influenciador += 0.20;

            return influenciador;
        }

        public static double obtemInfluenciadorCriativo(DNA dna)
        {
            double influenciador = 0.40;

            if (dna.mgneCriativoNv1 == enumGene.AA)
                influenciador += 0.35;

            if (dna.mgneCriativoNv1 == enumGene.Aa)
                influenciador += 0.10;

            if (dna.mgneCriativoNv2 == enumGene.AA)
                influenciador += 0.50;

            if (dna.mgneCriativoNv2 == enumGene.Aa)
                influenciador += 0.15;

            if (dna.mgneCriativoNv3 == enumGene.AA)
                influenciador += 0.70;

            if (dna.mgneCriativoNv3 == enumGene.Aa)
                influenciador += 0.20;

            return influenciador;
        }

        public static double obtemInfluenciadorFertilidade(DNA dna)
        {
            double influenciador = 0.40;

            if (dna.mgneFertilidadeNv1 == enumGene.AA)
                influenciador += 0.35;

            if (dna.mgneFertilidadeNv1 == enumGene.Aa)
                influenciador += 0.10;

            if (dna.mgneFertilidadeNv2 == enumGene.AA)
                influenciador += 0.50;

            if (dna.mgneFertilidadeNv2 == enumGene.Aa)
                influenciador += 0.15;

            if (dna.mgneFertilidadeNv3 == enumGene.AA)
                influenciador += 0.70;

            if (dna.mgneFertilidadeNv3 == enumGene.Aa)
                influenciador += 0.20;

            return influenciador;
        }

        public static double obtemInfluenciadorViolento(DNA dna)
        {
            double influenciador = 0.40;

            if (dna.mgneViolentoNv1 == enumGene.AA)
                influenciador += 0.35;

            if (dna.mgneViolentoNv1 == enumGene.Aa)
                influenciador += 0.10;

            if (dna.mgneViolentoNv2 == enumGene.AA)
                influenciador += 0.50;

            if (dna.mgneViolentoNv2 == enumGene.Aa)
                influenciador += 0.15;

            if (dna.mgneViolentoNv3 == enumGene.AA)
                influenciador += 0.70;

            if (dna.mgneViolentoNv3 == enumGene.Aa)
                influenciador += 0.20;

            return influenciador;
        }

        public static double obtemInfluenciadorReligioso(DNA dna)
        {
            double influenciador = 0.5;

            if (dna.mgneReligioso == enumGene.Aa)
                influenciador += 0.65;

            if (dna.mgneReligioso == enumGene.AA)
                influenciador += 0.80;

            return influenciador;
        }

        public static double obtemInfluenciadorDepressao(DNA dna)
        {
            double influenciador = 0.5;

            if (dna.mgneDepressao == enumGene.Aa)
                influenciador += 0.65;

            if (dna.mgneDepressao == enumGene.AA)
                influenciador += 0.8;

            return influenciador;
        }
    }
}
