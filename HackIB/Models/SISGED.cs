namespace HackIB.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class SISGED : DbContext
    {
        public SISGED()
            : base("name=SISGED")
        {
        }

        public virtual DbSet<gedtb001_demanda> gedtb001_demanda { get; set; }
        public virtual DbSet<gedtb002_historico_demanda> gedtb002_historico_demanda { get; set; }
        public virtual DbSet<gedtb004_servico> gedtb004_servico { get; set; }
        public virtual DbSet<gedtb006_situacao> gedtb006_situacao { get; set; }
        public virtual DbSet<gedtb007_tipo_origem_demanda> gedtb007_tipo_origem_demanda { get; set; }
        public virtual DbSet<gedtb008_tipo_demanda> gedtb008_tipo_demanda { get; set; }
        public virtual DbSet<gedtb031_cidadao> gedtb031_cidadao { get; set; }
        public virtual DbSet<icotb001_unidades_caixa> icotb001_unidades_caixa { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            this.Configuration.LazyLoadingEnabled = false;

            modelBuilder.Entity<gedtb001_demanda>()
                .Property(e => e.co_unidade_origem)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<gedtb001_demanda>()
                .Property(e => e.co_empregado_responsavel)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<gedtb001_demanda>()
                .Property(e => e.co_empregado_cadastro)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<gedtb001_demanda>()
                .Property(e => e.nu_identificador)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<gedtb001_demanda>()
                .Property(e => e.no_demandante)
                .IsUnicode(false);

            modelBuilder.Entity<gedtb001_demanda>()
                .Property(e => e.ed_email_demandante)
                .IsUnicode(false);


            modelBuilder.Entity<gedtb001_demanda>()
                .HasMany(e => e.gedtb002_historico_demanda);

 

            modelBuilder.Entity<gedtb002_historico_demanda>()
                .Property(e => e.co_empregado)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<gedtb002_historico_demanda>()
                .Property(e => e.tx_apontamento)
                .IsUnicode(false);

            modelBuilder.Entity<gedtb004_servico>()
                .Property(e => e.no_servico)
                .IsUnicode(false);

            modelBuilder.Entity<gedtb004_servico>()
                .Property(e => e.tx_descricao)
                .IsUnicode(false);


            modelBuilder.Entity<gedtb006_situacao>()
                .Property(e => e.no_situacao)
                .IsUnicode(false);

            modelBuilder.Entity<gedtb006_situacao>()
                .HasMany(e => e.gedtb001_demanda)
                .WithRequired(e => e.gedtb006_situacao)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<gedtb007_tipo_origem_demanda>()
                .Property(e => e.no_tipo_origem_demanda)
                .IsUnicode(false);

            modelBuilder.Entity<gedtb007_tipo_origem_demanda>()
                .HasMany(e => e.gedtb001_demanda)
                .WithRequired(e => e.gedtb007_tipo_origem_demanda)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<gedtb008_tipo_demanda>()
                .Property(e => e.no_tipo_demanda)
                .IsUnicode(false);

            modelBuilder.Entity<gedtb008_tipo_demanda>()
                .HasMany(e => e.gedtb001_demanda)
                .WithRequired(e => e.gedtb008_tipo_demanda)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<gedtb008_tipo_demanda>()
                .HasMany(e => e.gedtb004_servico)
                .WithRequired(e => e.gedtb008_tipo_demanda)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<gedtb031_cidadao>()
                .Property(e => e.co_nis)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<gedtb031_cidadao>()
                .Property(e => e.co_cpf)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<gedtb031_cidadao>()
                .Property(e => e.no_cidadao)
                .IsUnicode(false);

            modelBuilder.Entity<gedtb031_cidadao>()
                .Property(e => e.nu_identificacao)
                .IsUnicode(false);

            modelBuilder.Entity<gedtb031_cidadao>()
                .Property(e => e.co_uf_identificacao)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<gedtb031_cidadao>()
                .Property(e => e.no_mae)
                .IsUnicode(false);

            modelBuilder.Entity<gedtb031_cidadao>()
                .Property(e => e.nu_telefone)
                .IsUnicode(false);

            modelBuilder.Entity<gedtb031_cidadao>()
                .Property(e => e.co_matricula)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<gedtb031_cidadao>()
                .HasMany(e => e.gedtb001_demanda)
                .WithRequired(e => e.gedtb031_cidadao)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<icotb001_unidades_caixa>()
                .Property(e => e.nu_unidade)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<icotb001_unidades_caixa>()
                .Property(e => e.no_unidade)
                .IsUnicode(false);

            modelBuilder.Entity<icotb001_unidades_caixa>()
                .Property(e => e.ed_alias)
                .IsUnicode(false);

            modelBuilder.Entity<icotb001_unidades_caixa>()
                .Property(e => e.ed_email_interno)
                .IsUnicode(false);

            modelBuilder.Entity<icotb001_unidades_caixa>()
                .Property(e => e.ed_email_externo)
                .IsUnicode(false);

            modelBuilder.Entity<icotb001_unidades_caixa>()
                .Property(e => e.no_situacao)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<icotb001_unidades_caixa>()
                .Property(e => e.no_tipo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<icotb001_unidades_caixa>()
                .Property(e => e.sg_unidade)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<icotb001_unidades_caixa>()
                .Property(e => e.co_ibge)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<icotb001_unidades_caixa>()
                .Property(e => e.co_uf)
                .IsFixedLength()
                .IsUnicode(false);


        }
    }
}
