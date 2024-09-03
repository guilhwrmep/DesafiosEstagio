using System;


namespace DesafiosTecnicos
{
    internal class UltimosDesafios
    {

        // 4) Descubra a lógica e complete o próximo elemento:
        //a) 1, 3, 5, 7, ---
        //b) 2, 4, 8, 16, 32, 64, ____
        //c) 0, 1, 4, 9, 16, 25, 36, ____
        //d) 4, 16, 36, 64, ____
        //e) 1, 1, 2, 3, 5, 8, ____
        //f) 2,10, 12, 16, 17, 18, 19, ____

        // A - 9, B - 128, C - 49, D - 100, E - 13, F - 20



        // 5) Você está em uma sala com três interruptores, cada um conectado a uma lâmpada em salas diferentes.
        // Você não pode ver as lâmpadas da sala em que está, mas pode ligar e desligar os interruptores quantas vezes quiser.
        // Seu objetivo é descobrir qual interruptor controla qual lâmpada.
        // Como você faria para descobrir, usando apenas duas idas até uma das salas das lâmpadas, qual interruptor controla cada lâmpada?
        //
        // Resposta:
        // Irei ligar o Interruptor 1 e deixe-o ligado por alguns minutos (digamos, 5 minutos). Isso permitirá que a lâmpada correspondente a esse interruptor aqueça.

         //Depois de 5 minutos, irei desligar o Interruptor 1 e ligar o Interruptor 2.

        //Imediatamente irei até a primeira sala de lâmpadas. Observando a lâmpada nessa sala:

         //Se a lâmpada estiver acesa, então o Interruptor 2 controla essa lâmpada.
        //Se a lâmpada estiver apagada, toquei para verificar sua temperatura:
       //Se a lâmpada estiver quente, então o Interruptor 1 controla essa lâmpada.
       //Se a lâmpada estiver fria, então o Interruptor 3 controla essa lâmpada.
      //Agora vou até a segunda sala de lâmpadas (ou a terceira, se necessário, dependendo dos resultados da etapa anterior):

      //A lâmpada que está acesa corresponde ao Interruptor 2.
      //A lâmpada que está apagada e quente corresponde ao Interruptor 1.
     //A lâmpada que está apagada e fria corresponde ao Interruptor 3. 

    }
}
