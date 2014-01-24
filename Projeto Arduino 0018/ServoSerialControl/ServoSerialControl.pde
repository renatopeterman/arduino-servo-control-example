// Importa a biblioteca Servo.h do arduino
#include <Servo.h>

// Cria uma variavel do tipo Servo que será
// o nosso servo.
Servo servo1;

// Array de char que receberá o comando
// via serial
char buffer[4];

// Variavel que identifica quantos
// caracteres foram recebidos, pois só é
// possível receber um caracter por vez
int received;

void setup(){
  
  // Define o baud rate (taxa de trasmissão) como 9600
  Serial.begin(9600);
  
  // Atribui o servo ao pino 8 do Arduino
  servo1.attach(8);
  
  // Atribui o valor 0 para a variavel received
  received = 0;
  
  // Na posição 0 do array, atribui o valor '\0'
  // que identifica onde começa o array
  buffer[received] = '\0';
}

void loop(){
  
  // Verifica se existe alguma entrada de dados
  // disponivel na entrada serial
  if(Serial.available()){

    // Salva os caracteres no array a cada iteração
    buffer[received++] = Serial.read();
    
    
    if(received >= (sizeof(buffer)-1)){
      
      // Imprime na saída serial o valor
      // Apenas para mostrar o valor
      Serial.println(buffer);
      
      // Converte o valor de "char" para "int"
      int numero = atoi(buffer);
      
      // Envia o comando para o Servo Motor
      servo1.write(numero);
      
      // Zera novamente a variavel
      received = 0; 
    }
    
    // Limpa o buffer da entrada serial
    Serial.flush();
    
  }

}
