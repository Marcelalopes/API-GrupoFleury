# Desafio Back-end - Grupo Fleury

## Descrição:

O Grupo Fleury é uma rede de clinicas e está precisando de uma api restfull para realização de agendamentos para seus clientes, 
para tal o usuário precisará ter um cadastro de cliente em nossa base de dados, 
selecionar um exame e informar data e hora desejado.

## Features
- Deverá haver um endpoint para criação de um cliente
- Deverá haver um endpoint para atualização de um cliente
- Deverá haver um endpoint para desativar um cliente
- Deverá haver um endpoint para busca de um cliente baseado no seu cpf ou Nome
- Deverá haver um endpoint para listagem de todos os clientes cadastrados com paginação

- Deverá haver um endpoint para listagem dos exames disponíveis para agendamento, exibindo apenas nome do exame e id
- Deverá haver um endpoint para listagem dos agendamentos de um cliente por cpf, deverá conter o valor total (soma dos valores dos exames selecionados para o agendamento)
- Deverá haver um endpoint para a criação de uma agendamento
- Deverá haver um endpoint para edição de um agendamento realizado, apenas dia e hora poderão ser editados
- Deverá haver um endpoint para desativar um agendamento realizado

## Regras de Negócio

- Cliente precisa estar cadastrado em base de dados para realizar o agendamento
- Caso o cliente não exista em base, deverá ser feito o cadastro antecipadamente.
- Não será possível realizar agendamento de mais de 2 pacientes para o mesmo exame na mesma data e hora.
- O cadastro de cliente deverá ter os campos: Nome, CPF, Data de Nascimento, Endereço
- Não poderá ser cadastrado mais de um cliente para o mesmo CPF
- O Cliente pode ter um agendamento para mais de um exame
- Nenhum cliente pode ser excluido da base de dados

## Requisitos

- Injeção de Dependência
- Padrão DTO
- Padrão Repository
- Git e GitHub