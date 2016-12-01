<Query Kind="Program" />

static string ToCSharpFriendlyName(string timeZoneId)
	=> timeZoneId.Replace("-", "Minus")
				 .Replace("+", "Plus")
				 .Replace(" ", "")
				 .Replace("(", "In")
				 .Replace(")", "")
				 .Replace(".", "");

static string GenFunctionDocumentationToLocal(TimeZoneInfo tzi)
	=>
$@"///<summary>
///Converts UTC to {tzi.Id}
///<para>Id: {tzi.Id}</para>
///<para>Display Name: {tzi.DisplayName}</para>
///<para>Standard Name: {tzi.StandardName}</para>
///<para>Daylight Name: {tzi.DaylightName}</para>
///<para>Base Utc Offset: {tzi.BaseUtcOffset}</para>
///<para>Supports Daylight Savings Time: {tzi.SupportsDaylightSavingTime}</para>
///</summary>";

static string GenFunctionDef(string cSharpMethodName, string cSharpFieldName)
	=> $"public static DateTime {cSharpMethodName}FromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, {cSharpFieldName});";

static string GenTimeZoneInfoField(string cSharpFieldName)
	=> $"static readonly TimeZoneInfo {cSharpFieldName};";

static string GenTimeZoneInfoFieldAssignment(string cSharpFieldName, string valueFetcher)
	=> $"{cSharpFieldName} = {valueFetcher};";

void Main()
{
	var tzis = TimeZoneInfo.GetSystemTimeZones()
						   .OrderBy(x => x.Id);

	const string CLASS_NAME = "DateTimeTimeZoneExt";

	$"public static class {CLASS_NAME}".Dump();
	"{".Dump();

	foreach (var tzi in tzis)
	{
		var cSharpName = ToCSharpFriendlyName(tzi.Id);

		GenTimeZoneInfoField($"_{cSharpName}").Dump();
		GenFunctionDocumentationToLocal(tzi).Dump();
		GenFunctionDef($"To{cSharpName}", $"_{cSharpName}").Dump();
		"".Dump();
	}


	$"static {CLASS_NAME}()".Dump();
	"{".Dump();
	"\tvar tzis = TimeZoneInfo.GetSystemTimeZones();".Dump();
	
	foreach (var tzi in tzis)
	{
		var cSharpName = ToCSharpFriendlyName(tzi.Id);

		GenTimeZoneInfoFieldAssignment($"_{cSharpName}", $"tzis.First(x => x.Id == \"{tzi.Id}\")").Dump();
	}

	"}".Dump();
	
	"}".Dump();
}