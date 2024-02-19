# DIO - Trilha .NET - Programação orientada a objetos
www.dio.me

## Desafio de projeto
Para este desafio, você precisará usar seus conhecimentos adquiridos no módulo de orientação a objetos, da trilha .NET da DIO.

## Contexto
Você é responsável por modelar um sistema que trabalha com celulares. Para isso, foi solicitado que você faça uma abstração de um celular e disponibilize maneiras de diferentes marcas e modelos terem seu próprio comportamento, possibilitando um maior reuso de código e usando a orientação a objetos.

## Proposta
Você precisa criar um sistema em .NET, do tipo console, mapeando uma classe abstrata e classes específicas para dois tipos de celulares: Nokia e iPhone. 
Você deve criar as suas classes de acordo com o diagrama abaixo:

![Diagrama classes](Imagens/diagrama.png)

## Regras e validações
1. A classe **Smartphone** deve ser abstrata, não permitindo instanciar e servindo apenas como modelo.
2. A classe **Nokia** e **Iphone** devem ser classes filhas de Smartphone.
3. O método **InstalarAplicativo** deve ser sobrescrito na classe Nokia e iPhone, pois ambos possuem diferentes maneiras de instalar um aplicativo.

## Solução
O código está pela metade, e você deverá dar continuidade obedecendo as regras descritas acima, para que no final, tenhamos um programa funcional. Procure pela palavra comentada "TODO" no código, em seguida, implemente conforme as regras acima.

## Novidades Implementadas
Modelos de Smartphone
1. Lenovo
2. Samsung

Funcionalidades Gerais
1. Escolha de Contatos ao Ligar = Agora, ao ligar o smartphone, você pode escolher entre digitar um número manualmente ou escolher um contato salvo.
2. Recebimento de Ligação Aleatório = Quando receber uma ligação, o sistema faz um sorteio entre os contatos salvos. Se não houver contatos, será uma chamada de número desconhecido.
3. Download de Aplicativos com Tamanho Específico = Ao baixar um aplicativo, o sistema solicita o tamanho do aplicativo, e a quantidade de memória do smartphone é reduzida de acordo.
4. Envio de SMS com Limite de Caracteres = Agora é possível enviar SMS, escolhendo entre digitar um número ou selecionar um contato. Há um limite de 500 caracteres para a mensagem.
5. Validação de Números em Ligações e SMS = Foi adicionada uma validação para garantir que o usuário insira apenas números ao fazer ligações e enviar SMS. Caso contrário, será lançada uma exceção.
6. Checagem de Memória Disponível = Adicionada uma função para verificar a quantidade de memória disponível no smartphone.
