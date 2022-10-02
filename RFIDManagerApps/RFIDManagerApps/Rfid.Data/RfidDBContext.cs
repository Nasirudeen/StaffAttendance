//using Microsoft.Azure.Documents;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//public class RfidDbContext : DbContext, IUnitOfWork
//{
//    public RfidDbContext(DbContextOptions<RfidDbContext> options)
//: base(options)
//    {


//    }



//    /// <summary>
//    /// Localization Objects
//    /// </summary>      
//    public DbSet<AuditTrail> AuditTrails { get; set; }   
//    public DbSet<User> Users { get; set; }
 
//        public int Save()
//    {

//        try
//        {

//            var entities = from e in ChangeTracker.Entries()
//                           where e.State == EntityState.Added
//                               || e.State == EntityState.Modified
//                           select e.Entity;
//            foreach (var entity in entities)
//            {
//                var validationContext = new ValidationContext(entity);
//                Validator.ValidateObject(entity, validationContext);
//            }
//            return base.SaveChanges();
//        }
//        catch (Exception ex)
//        {


//            throw ex;
//        }
//    }







//    protected virtual string CreateSqlWithParameters(string sql, params object[] parameters)
//    {
//        //add parameters to sql
//        for (var i = 0; i <= (parameters?.Length ?? 0) - 1; i++)
//        {
//            if (!(parameters[i] is DbParameter parameter))
//                continue;

//            sql = $"{sql}{(i > 0 ? "," : string.Empty)} @{parameter.ParameterName}";

//            //whether parameter is output
//            if (parameter.Direction == ParameterDirection.InputOutput || parameter.Direction == ParameterDirection.Output)
//                sql = $"{sql} output";
//        }

//        return sql;
//    }


//    public virtual new DbSet<TEntity> Set<TEntity>() where TEntity : class
//    {
//        return base.Set<TEntity>();
//    }


//    public virtual string GenerateCreateScript()
//    {
//        return this.Database.GenerateCreateScript();
//    }


//    public virtual IQueryable<TQuery> QueryFromSql<TQuery>(string sql) where TQuery : class
//    {
//        return this.Query<TQuery>().FromSql(sql);
//    }


//    public virtual IQueryable<TEntity> EntityFromSql<TEntity>(string sql, params object[] parameters) where TEntity : class
//    {
//        return this.Set<TEntity>().FromSql(CreateSqlWithParameters(sql, parameters), parameters);
//    }


//    public virtual int ExecuteSqlCommand(RawSqlString sql, bool doNotEnsureTransaction = false, int? timeout = null, params object[] parameters)
//    {
//        //set specific command timeout
//        var previousTimeout = this.Database.GetCommandTimeout();
//        this.Database.SetCommandTimeout(timeout);

//        var result = 0;
//        if (!doNotEnsureTransaction)
//        {
//            //use with transaction
//            using (var transaction = this.Database.BeginTransaction())
//            {
//                result = this.Database.ExecuteSqlCommand(sql, parameters);
//                transaction.Commit();
//            }
//        }
//        else
//            result = this.Database.ExecuteSqlCommand(sql, parameters);

//        //return previous timeout back
//        this.Database.SetCommandTimeout(previousTimeout);

//        return result;
//    }


//    public virtual void Detach<TEntity>(TEntity entity) where TEntity : class
//    {
//        if (entity == null)
//            throw new ArgumentNullException(nameof(entity));

//        var entityEntry = this.Entry(entity);
//        if (entityEntry == null)
//            return;

//        //set the entity is not being tracked by the context
//        entityEntry.State = EntityState.Detached;
//    }



//}
//}

