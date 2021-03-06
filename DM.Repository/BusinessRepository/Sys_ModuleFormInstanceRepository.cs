//------------------------------------------------------------------------------
// <auto-generated>
//     此代码从T4模板生成。
//     黄正辉（623128629@qq.com）
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Data.Common;
using DM.Domain;
using DM.Tools;
using DM.Interface;
using DM.Interface.IRepository;

namespace DM.Repository.BusinessRepository
{
    /// <summary>
    /// 仓储实现：模块表单实例 (Sys_ModuleFormInstance)
    /// </summary>
    public partial class Sys_ModuleFormInstanceRepository :RepositoryBase<Sys_ModuleFormInstance>,  ISys_ModuleFormInstanceRepository,IDependency
    {
        /// <summary>
        /// 插入一个数据
        /// </summary>
        /// <param name="entity">实体</param>
        /// <returns>受影响行数</returns>
        public virtual int Insert(Sys_ModuleFormInstance entity)
        {
            return base.Insert(entity);
        }
        /// <summary>
        /// 插入一个数据列表
        /// </summary>
        /// <param name="entity">实体列表</param>
        /// <returns>受影响行数</returns>
        public virtual int Insert(List<Sys_ModuleFormInstance> entitys)
        {
            return base.Insert(entitys);
        }
        /// <summary>
        /// 修改一个数据
        /// </summary>
        /// <param name="entity">实体</param>
        /// <returns>受影响行数</returns>
        public virtual int Update(Sys_ModuleFormInstance entity)
        {
            return base.Update(entity);
        }
        /// <summary>
        /// 删除一个数据
        /// </summary>
        /// <param name="entity">实体</param>
        /// <returns>受影响行数</returns>
        public virtual int Delete(Sys_ModuleFormInstance entity)
        {
            return base.Delete(entity);
        }
        /// <summary>
        /// 根据表达式删除
        /// </summary>
        /// <param name="predicate">实体</param>
        /// <returns>受影响行数</returns>
        public virtual int Delete(Expression<Func<Sys_ModuleFormInstance, bool>> predicate)
        {
            return base.Delete(predicate);
        }
        /// <summary>
        /// 根据主键查询一个数据
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <returns>实体</returns>
        public virtual Sys_ModuleFormInstance FindEntity(object keyValue)
        {
            return base.FindEntity(keyValue);
        }
        /// <summary>
        /// 根据表达式查询一个数据
        /// </summary>
        /// <param name="predicate">表达式</param>
        /// <returns>实体</returns>
        public virtual Sys_ModuleFormInstance FindEntity(Expression<Func<Sys_ModuleFormInstance, bool>> predicate)
        {
            return base.FindEntity(predicate);
        }
        /// <summary>
        /// 查询IQueryable列表
        /// </summary>
        /// <returns>IQueryable列表</returns>
        public virtual IQueryable<Sys_ModuleFormInstance> IQueryable()
        {
            return base.IQueryable();
        }
        /// <summary>
        /// 根据表达式查询IQueryable列表数据
        /// </summary>
        /// <param name="predicate">表达式</param>
        /// <returns>IQueryable列表</returns>
        public virtual IQueryable<Sys_ModuleFormInstance> IQueryable(Expression<Func<Sys_ModuleFormInstance, bool>> predicate)
        {
            return base.IQueryable(predicate);
        }
        /// <summary>
        /// 根据Sql查询数据
        /// </summary>
        /// <param name="strSql">Sql</param>
        /// <returns>数据列表</returns>
        public virtual List<Sys_ModuleFormInstance> FindList(string strSql)
        {
            return base.FindList(strSql);
        }
        /// <summary>
        /// 根据Sql查询数据
        /// </summary>
        /// <param name="strSql">Sql</param>
        /// <param name="dbParameter">参数列表</param>
        /// <returns>数据列表</returns>
        public virtual List<Sys_ModuleFormInstance> FindList(string strSql, DbParameter[] dbParameter)
        {
            return base.FindList(strSql,dbParameter);
        }
        /// <summary>
        /// 查询分页数据
        /// </summary>
        /// <param name="pagination">分页参数</param>
        /// <returns>数据列表</returns>
        public virtual List<Sys_ModuleFormInstance> FindList(Pagination pagination)
        {
            return base.FindList(pagination);
        }
        /// <summary>
        /// 查询表达式查询分页数据
        /// </summary>
        /// <param name="predicate">表达式</param>
        /// <param name="pagination">分页参数</param>
        /// <returns>数据列表</returns>
        public virtual List<Sys_ModuleFormInstance> FindList(Expression<Func<Sys_ModuleFormInstance, bool>> predicate, Pagination pagination)
        {
            return base.FindList(predicate,pagination);
        }
    }
}
