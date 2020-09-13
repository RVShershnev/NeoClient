using Neo4j.Driver.V1;
using NeoClient.Attributes;
using System;
using System.Collections.Generic;
using ITransaction = NeoClient.TransactionManager.ITransaction;

namespace NeoClient
{
    public interface INeoClient : IDisposable
    {
       
        IList<T> GetByProperty<T>(
            string propertyName, 
            object propertValue) where T : EntityBase, new();
        IList<T> GetByProperties<T>(Dictionary<string, object> entity) where T : EntityBase, new();
        T Add<T>(T entity) where T : EntityBase, new();
        T Update<T>(
            T entity, 
            string id, 
            bool fetchResult = false) where T : EntityBase, new();
        T Delete<T>(string uuid) where T : EntityBase, new();
        T GetByUuidWithRelatedNodes<T>(string uuid) where T : EntityBase, new();
        IList<T> GetAll<T>(string where = default) where T : EntityBase, new();
        bool CreateRelationship(
            string uuidFrom,
            string uuidTo,
            RelationshipAttribute relationshipAttribute,
            Dictionary<string, object> props = null);
        T Merge<T>(
            T entityOnCreate, 
            T entityOnUpdate, 
            string where) where T : EntityBase, new();
        IStatementResult MergeRelationship(
            string uuidFrom,
            string uuidTo,
            RelationshipAttribute relationshipAttribute);
        bool Drop<T>(string uuid) where T : EntityBase, new();
        bool DropRelationshipBetweenTwoNodes(
            string uuidIncoming,
            string uuidOutgoing,
            RelationshipAttribute relationshipAttribute);
        IList<T> RunCustomQuery<T>(
            string query, 
            Dictionary<string, object> parameters) where T : class, new();
        IStatementResult RunCustomQuery(
            string query, 
            Dictionary<string, object> parameters = null);
        //TODO: will be removed after isDeleted refactor
        int DropByProperties<T>(Dictionary<string, object> props) where T : EntityBase, new();
        bool AddLabel(string uuid, string newLabelName);
        void Connect();
        ITransaction BeginTransaction();
        bool Ping();

        IStatementResult DeleteAll();
        IEnumerable<T> Add<T>(params T[] entities) where T : EntityBase, new();
        IEnumerable<T> Add<T>(IEnumerable<T> entities) where T : EntityBase, new();

        (IStatementResult, List<string>) AddNodeWithAll(IEntityBase entity, int deep = int.MaxValue);

       
       
        IStatementResult Merge(string uuid);

        IStatementResult Merge<T>(T uuid) where T:EntityBase, new();

        IStatementResult CreateIndex<T>(T entity, string propertyName) where T : EntityBase;
        IStatementResult DropIndex<T>(T entity, string propertyName) where T : EntityBase;

        /// <summary>
        /// List all constraints in the database.
        /// </summary>
        /// <returns>List all constraints in the database.</returns>
        IStatementResult Constraints();
    }
}