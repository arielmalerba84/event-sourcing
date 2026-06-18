using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace Ticketing.Command.Domain.Common;

public class Document : IDocumentacion
{
    [BsonId]
    [BsonRepresentation(BsonType.String)]
    public Object Id { get; set; }
}