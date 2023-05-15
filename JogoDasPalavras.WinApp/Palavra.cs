﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDasPalavras.WinApp
{
    public class Palavra
    {

        public string ObterPalavraSecreta()
        {


            string[] palavras =
            {

             "ACIDO", "ADIAR", "IMPAR", "ALGAR", "AMADO", "AMIGO", "ANEXO", "ANUIR", "AONDE", "APELO",
             "AQUEM", "ARGIL", "ARROZ", "ASSAR", "ATRAS", "AVIDO", "AZERI", "BABAR", "BAGRE", "BANHO",
             "BARCO", "BICHO", "BOLOR", "BRASA", "BRAVA", "BRISA", "BRUTO", "BULIR", "CAIXA", "CANSA",
             "CHATO", "CHAVE", "CHEFE", "CHORO", "CHULO", "CLARO", "COBRE", "CORTE", "CURAR", "DEIXO",
             "DIZER", "DOGMA", "DORES", "DUQUE", "ENFIM", "ESTOU", "EXAME", "FALAR", "FARDO", "FARTO",
             "FATAL", "FELIZ", "FICAR", "FOGUE", "FORCA", "FORNO", "FRACO", "FUGIR", "FUNDO", "FURIA",
             "GAITA", "GASTO", "GEADA", "GELAR", "GOSTO", "GRITO", "GUETO", "HONRA", "HUMOR", "IDADE",
             "IDEIA", "IDOLO", "IGUAL", "IMUNE", "INDIO", "INGUA", "IRADO", "ISOLA", "JANTA", "JOVEM",
             "JUIZO", "LARGO", "LASER", "LEITE", "LENTO", "LERDO", "LEVAR", "LIDAR", "LINDO", "LIRO",
             "LONGE", "LUZES", "MAGRO", "MAIOR", "MALTE", "MAMAR", "MANTO", "MARCA", "MATAR", "MEIGO",
             "MEIOS", "MELAO", "MESMO", "METRO", "MIMOS", "MOEDA", "MOITA", "MOLHO", "MORNO", "MORRO",
             "MOTIM", "MUITO", "MURAL", "NAIPE", "NASCI", "NATAL", "NAVAL", "NINAR", "NIVEL", "NOBRE",
             "NOITE", "NORTE", "NUVEM", "OESTE", "OMBRO", "ORDEM", "ORGAO", "OSSEO", "OSSOS", "OUTRO",
             "OUVIR", "PALMA", "PARDO", "PASSE", "PATIO", "PEITO", "PELOS", "PERDO", "PERIL", "PERTO",
             "PEZAR", "PIANO", "PICAR", "PILAR", "PINGO", "PIONE", "PISTA", "PODER", "POREM", "PRADO",
             "PRATO", "PRAZO", "PRECO", "PRIMA", "PRIMO", "PULAR", "QUERO", "QUOTA", "RAIVA", "RAMPA",
             "RANGO", "REAIS", "REINO", "REZAR"

            };
            int indiceAleatorio = new Random().Next(palavras.Length);

            return palavras[indiceAleatorio];
        }
    }
    }

