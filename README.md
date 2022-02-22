# ProjBancoAPI

Configuração para executar o projeto:

Abra o projeto clonado no Visual Estudio, clique em Ferramentas -> Gerenciador de pacotes do NuGet -> Console do Gerenciador de pacotes
![PASSO1](https://user-images.githubusercontent.com/63134386/155151114-aac659c7-fec3-4972-b9ad-8daaec5d831f.png)

Digite update-database e clique enter para criar o banco de dados Sql Server local e as tabelas.
![PASSO2](https://user-images.githubusercontent.com/63134386/155151423-53310b74-a134-43ca-9cc8-9f1018c8daac.png)

Verifique que deu certo.
![PASSO3](https://user-images.githubusercontent.com/63134386/155151648-224b8206-998c-45d5-a893-aae3a1e26c02.png)
![PASSO4](https://user-images.githubusercontent.com/63134386/155151667-55e9d7d7-871d-41c0-9075-458308b0ccad.png)
![PASSO5](https://user-images.githubusercontent.com/63134386/155151908-a964610d-16d7-4f4f-9e0a-a61ecff3d67a.png)

Execute o projeto.
![PASSO6](https://user-images.githubusercontent.com/63134386/155151994-3520ca5c-45b7-487b-b86f-5d96ec1ead1c.png)

Faça uma requisição Post para a rota http://localhost:5094/cartao passando o json no body

tipo 0 = Crédito

tipo 1 = Débito

    {
      "tipo": 0,
      "extrato": {
          "saldoAtual": 320.20,
          "lancamentos": [
              {
                  "descricao": "Descrição aqui 5...",
                  "valor": 44.2,
                  "data": "2022-02-22"
              },
              {
                  "descricao": "Descrição aqui 4...",
                  "valor": 209.2,
                  "data": "2022-02-21"
              },
              {
                  "descricao": "Descrição aqui 3...",
                  "valor": 39.1,
                  "data": "2022-02-20"
              },
              {
                  "descricao": "Descrição aqui 2...",
                  "valor": 10.7,
                  "data": "2022-02-19"
              },
              {
                  "descricao": "Descrição aqui 1...",
                  "valor": 22.0,
                  "data": "2022-02-18"
              }
          ] 
      }
    }

![PASSO7](https://user-images.githubusercontent.com/63134386/155153197-516248eb-b608-42ef-9e78-bbc45df666c7.png)

A requisição Get para a rota http://localhost:5094/cartao/1?dias=3 retorna os dados do cartão com o id passado e 3 Lançamentos do extrato

![PASSO8](https://user-images.githubusercontent.com/63134386/155154879-3a1f3c92-4bc1-40dd-bc74-6c8bbf1f5620.png)

