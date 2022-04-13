namespace LEAR_NOTE.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<LEAR_NOTE.Models.Contexto>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(LEAR_NOTE.Models.Contexto context)
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            SetSqlGenerator("MySql.Data.MySqlClient", new
            MySql.Data.Entity.MySqlMigrationSqlGenerator());

            context.Usuario.AddOrUpdate(
            p => p.Email,
            new Models.Usuario
            {
                Id = 1,
                Nome = "Lucas",
                Email = "luca@fatec.com.br",
                Senha ="vDDsx1jGNpHGnmbYRjJmcJJL/5YJtf6/OcHobMqPtyeDrV5bcHY1nm1wm8WM03mt4UlZRfhZHph2yyY05DE5pg=="
             },

            new Models.Usuario

            {
                Id = 2,
                Nome = "Pedro",
                Email = "pedro@fatec.com.br",
                Senha ="vDDsx1jGNpHGnmbYRjJmcJJL/5YJtf6/OcHobMqPtyeDrV5bcHY1nm1wm8WM03mt4UlZRfhZHph2yyY05DE5pg=="
            },

            new Models.Usuario
            {
                Id = 3,
                Nome = "Leonardo",
                Email = "Leonardo@fatec.com.br",
                Senha = "vDDsx1jGNpHGnmbYRjJmcJJL/5YJtf6/OcHobMqPtyeDrV5bcHY1nm1wm8WM03mt4UlZRfhZHph2yyY05DE5pg=="
                });
            context.Perfil.AddOrUpdate(
            p => p.Descricao,
            new Models.Perfil { Id = 1, Descricao = "Admin" },
            new Models.Perfil { Id = 2, Descricao = "Comum" },
            new Models.Perfil { Id = 3, Descricao = "Gerente" });
            context.UsuarioPerfil.AddOrUpdate(
            p => p.Id,
            new Models.UsuarioPerfil { Id = 1, UsuarioId = 1, PerfilId = 1 },
            new Models.UsuarioPerfil { Id = 1, UsuarioId = 1, PerfilId = 2 },
            new Models.UsuarioPerfil { Id = 1, UsuarioId = 1, PerfilId = 3 },
            new Models.UsuarioPerfil { Id = 1, UsuarioId = 2, PerfilId = 2 },
            new Models.UsuarioPerfil { Id = 1, UsuarioId = 3, PerfilId = 3 });
        }
    }
}
