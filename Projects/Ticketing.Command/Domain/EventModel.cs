using MongoDB.Bson.Serialization.Attributes;
using Ticketing.Command.Domain.Common;
using Common.Core.Event;

namespace Ticketing.Command.Domain;

[BsonCollection("eventStores")]
public class EventModel : Document
{
    [BsonElement("timestamp")]
    public DateTime Timestamp { get; set; }

    [BsonElement("aggregateIdentifier")]
    public required string AggregateIdentifier { get; set; }

    [BsonElement("aggregateType")]
    public string AggregateType { get; set; } = string.Empty;

    public BaseEvent? EventData { get; set; } 
}