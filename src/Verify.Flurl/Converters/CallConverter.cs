class CallConverter :
    WriteOnlyJsonConverter<FlurlCall>
{
    public override void Write(VerifyJsonWriter writer, FlurlCall value)
    {
        writer.WriteStartObject();
        writer.WriteMember(value, value.HttpRequestMessage, "Request");
        writer.WriteMember(value, value.HttpResponseMessage, "Response");
        writer.WriteEndObject();
    }
}