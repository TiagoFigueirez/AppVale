Sistma que tem como objetivo de automatizar o vale de entrega da empresa invasive sp que e feito quuando a emissão de nota fiscal não está disponivel o app cadastra os dados necessarios em txt na pasta AppData no Micro e utiliza esses dados para enviar o vale nos e-mails dos reponsaveis do estoque
depois e emitido um vale de entrega em word com os produtos, que são adicionados no vale por um leitor de código de barras infravermelho.
O projeto tenta seguir os padrões SOLID e repositorio genérico para cadastrar qualquer tipo de dado nos TXT para isso e usado Interface, e invesão de depêndencia e o evento Key Press para fazer a leitura dos códigos de barras
Para usar o leitor deve-se ter um código de barras que divide os dados em três com espaços 

Projeto ainda está incompleto e em desenvolvimento
