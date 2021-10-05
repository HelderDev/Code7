# Code7

Projeto Conceito para entrevista com a [Code7](https://code7.com/) 


# 1. Conteúdo

A Loja de Informática WeChip possuía um sistema de créditos (em R$), que beneficiava clientes que compravam regularmente na loja. Esse sistema funcionou por muito tempo, mas agora, a loja decidiu encerrar este sistema. Como não havia prazo de validade para gastar, ela decidiu ligar pra todos estes clientes para que eles possam gastar os créditos, agilizar assim o processo de encerramento desse sistema de bonificação. Para isso, foi solicitado um sistema que possa ofertar alguns produtos para estes clientes. O projeto consiste em apenas 2 módulos (telas): CADASTRO CLIENTE e OFERTA

## 1.1 Cadastro Cliente

Deverá ter um cadastro simples de clientes, com os seguintes dados: 

 - NOME 
 - CPF  
 - CRÉDITO  
 - TELEFONE

### 1.1.1 Regras Cadastro Cliente

No momento do cadastro deverá ser salvo com status “Nome Disponível” Obs “Nome Disponível” é uma coluna da tabela STATUS. NOME, CPF e TELEFONE deverão ser obrigatórios.

## 1.2 Oferta

Ao cadastrar uma oferta ao cliente, deverá ser alterado o status do cliente. Para realizar uma oferta, deverá ser pesquisado um cliente pelo Nome ou CPF. O cliente que estiver com status finalizado (o status do cliente seja “FINALIZA CLIENTE” = Sim) não deverá aparecer mais na pesquisa.

Após ser feita a pesquisa, em uma lista de resultados, poderá ser selecionado um dos clientes e ser realizada a oferta (utilizar um botão “Ofertar”). Após selecionado o cliente, deverá ser apresentado a listagem de campos abaixo

### 1.2.1 Listagem Campos
DADOS CLIENTE 
 - NOME  	
 - CPF  	
 - TELEFONE  	
 - CRÉDITO  	
 - STATUS ATUAL

ENDEREÇO ENTREGA 
- CEP 
- RUA 
- NÚMERO
- COMPLEMENTO 
- BAIRRO
- CIDADE 
- ESTADO 
- 
PRODUTOS 
- OFERTA DOS PRODUTOS
 
STATUS 
- NOVO STATUS (Listagem de status, vide Material Apoio na última página)

### 1.2.2 Listagem Campos

- CRÉDITO E STATUS ATUAL não são editáveis (apenas para exibição). 
- NOME e TELEFONE são editáveis e obrigatórios sempre. 
- ENDEREÇO DE ENTREGA sempre é editável, mas somente será obrigatório caso seja selecionado algum produto do tipo HARDWARE. 
- Não poderá confirmar a venda (selecionar status que seja “CONTABILIZA VENDA” = Sim) caso: ◦ a soma dos produtos selecionados for maior que o CRÉDITO do cliente; ◦ não tiver nenhum produto selecionado. 
- Ao confirmar a venda deverá obrigar CPF e ao menos um produto selecionado.
- Não poderá recusar a venda (selecionar status que seja “CONTABILIZA VENDA” = Não) caso: ◦ estiver algum produto selecionado para venda;


# 2. Disponibilizar Informações


O cliente futuramente irá consumir algumas informações da venda em um sistema terceirizado. Por isso, precisa que deixe implementado uma API RESTful para disponibilizar os dados em JSON. Neste retorno, precisa trazer todas as ofertas feitas.
##### Segue abaixo um exemplo de como o resultado é esperado ao realizar a chamada do WS:

    { 
    	"codOferta" : 1, 
    	"codStatus" : 1, 
    	"idProduto" : 1, 
    	"CPF" : "01234567890" 
    }
##### Obs.: Não é necessário publicar o WS, basta apenas desenvolver.
