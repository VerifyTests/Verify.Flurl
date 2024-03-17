class HttpTestConverter :
    WriteOnlyJsonConverter<HttpTest>
{
    public override void Write(VerifyJsonWriter writer, HttpTest value) =>
        writer.Serialize(value.CallLog);
}