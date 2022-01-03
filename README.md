# Desafio Back-end - Grupo Fleury

## Descrição:

O Grupo Fleury é uma rede de clinicas e está precisando de uma api restfull para realização de agendamentos para seus clientes, 
para tal o usuário precisará ter um cadastro de cliente em nossa base de dados, 
selecionar um exame e informar data e hora desejado.

## Features
- Deverá haver um endpoint para criação de um cliente :heavy_check_mark:
- Deverá haver um endpoint para atualização de um cliente :heavy_check_mark:
- Deverá haver um endpoint para desativar um cliente :heavy_check_mark:
- Deverá haver um endpoint para busca de um cliente baseado no seu cpf ou Nome :heavy_check_mark:
- Deverá haver um endpoint para listagem de todos os clientes cadastrados com paginação :heavy_check_mark:

- Deverá haver um endpoint para listagem dos exames disponíveis para agendamento, exibindo apenas nome do exame e id :heavy_check_mark:
- Deverá haver um endpoint para listagem dos agendamentos de um cliente por cpf, deverá conter o valor total (soma dos valores dos exames selecionados para o agendamento) :heavy_check_mark:
- Deverá haver um endpoint para a criação de uma agendamento :heavy_check_mark:
- Deverá haver um endpoint para edição de um agendamento realizado, apenas dia e hora poderão ser editados :heavy_check_mark:
- Deverá haver um endpoint para desativar um agendamento realizado :heavy_check_mark:

## Regras de Negócio

- Cliente precisa estar cadastrado em base de dados para realizar o agendamento :heavy_check_mark:
- Caso o cliente não exista em base, deverá ser feito o cadastro antecipadamente. :heavy_check_mark:
- Não será possível realizar agendamento de mais de 2 pacientes para o mesmo exame na mesma data e hora.
- O cadastro de cliente deverá ter os campos: Nome, CPF, Data de Nascimento, Endereço :heavy_check_mark:
- Não poderá ser cadastrado mais de um cliente para o mesmo CPF :heavy_check_mark:
- O Cliente pode ter um agendamento para mais de um exame :heavy_check_mark:
- Nenhum cliente pode ser excluido da base de dados :heavy_check_mark:

## Requisitos

- Injeção de Dependência :heavy_check_mark:
- Padrão DTO :heavy_check_mark:
- Padrão Repository :heavy_check_mark:
- Git e GitHub :heavy_check_mark: