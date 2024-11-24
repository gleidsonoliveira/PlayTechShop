# 1.  Comando: Add-migration "InitialDatabase" -Context "PlayTechShopContext" :
   -  Função : Este comando cria uma nova migração chamada "InitialDatabase". Ele usa o contexto de banco de dados especificado (`PlayTechShopContext`). 
   -  Quando Usar : Quando você tem mais de um contexto de banco de dados em seu projeto e precisa criar uma migração para um contexto específico.

# 2.  Comando: update-database -Context "PlayTechShopContext" :
   -  Função : Aplica a última migração pendente ao banco de dados, usando o contexto especificado (`PlayTechShopContext`).
   -  Quando Usar : Similar ao anterior, é utilizado quando você tem múltiplos contextos e precisa aplicar a migração no banco de dados específico.

# 3.  Comando: add-migration "CreateAllTables" :
   -  Função : Este comando cria uma nova migração chamada "CreateAllTables". Ao ser executado, cria uma pasta de migrações se ainda não existir.
   -  Quando Usar : Usado para criar a primeira migração no projeto ou adicionar novas alterações ao banco de dados ao longo do tempo.

# 4.  Comando: update-database :
   -  Função : Aplica todas as migrações pendentes ao banco de dados, utilizando o contexto padrão definido no projeto.
   -  Quando Usar : Sempre que uma nova migração for criada e você quiser aplicá-la ao banco de dados.

# 5.  Comando: Update-Database -migration:"NomeMigration" :
   -  Função : Reverte o banco de dados até uma migração específica, indicada por `"NomeMigration"`.
   -  Quando Usar : Quando você precisa desfazer alterações e voltar a um estado anterior do banco de dados.

# 6.  Comando: Remove-Migration -Context "PlayTechShopContext" :
   -  Função : Reverte a última migração criada para o contexto específico (`PlayTechShopContext`). Ele remove a última migração do código sem alterar o banco de dados.
   -  Quando Usar : Quando você criou uma migração incorretamente ou precisa descartá-la por algum motivo.

# 7.  Comando: remove-migration -force :
   -  Função : Força a remoção da última migração gerada, excluindo o arquivo de migração e revertendo a classe Snapshot.
   -  Quando Usar : Quando uma migração precisa ser removida forçosamente, mesmo que não tenha sido aplicada ao banco de dados.

# 8.  Comando: script-migration -Context "PlayTechShopContext" :
   -  Função : Gera um script SQL que pode ser usado para aplicar as migrações no banco de dados, usando o contexto especificado (`PlayTechShopContext`).
   -  Quando Usar : Quando você precisa revisar ou aplicar as migrações manualmente em um ambiente diferente.

# 9.  Comando: script-migration -From InitialDatabase -To AddIncubatorCodeToTheInoculatorTable :
   -  Função : Gera um script SQL para migrar o banco de dados de um estado específico ("InitialDatabase") para outro estado específico ("AddIncubatorCodeToTheInoculatorTable").
   -  Quando Usar : Quando você precisa aplicar ou rever mudanças entre duas migrações específicas no banco de dados.