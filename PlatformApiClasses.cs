// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
using Newtonsoft.Json;

public class _200
    {
        public string? description { get; set; }
    }

    public class _204
    {
        public string description { get; set; }
    }

    public class _409
    {
        public string description { get; set; }
    }

    public class AccessToken
    {
        public string type { get; set; }
        public string description { get; set; }
    }

    public class Account
    {
        public string account_number { get; set; }
        public int apr { get; set; }
        public int apy { get; set; }
        public int available_balance { get; set; }
        public int available_credit { get; set; }
        public int balance { get; set; }
        public int cash_balance { get; set; }
        public int cash_surrender_value { get; set; }
        public DateTime created_at { get; set; }
        public int credit_limit { get; set; }
        public string currency_code { get; set; }
        public int day_payment_is_due { get; set; }
        public int death_benefit { get; set; }
        public string guid { get; set; }
        public int holdings_value { get; set; }
        public string id { get; set; }
        public DateTime imported_at { get; set; }
        public string institution_code { get; set; }
        public string insured_name { get; set; }
        public int interest_rate { get; set; }
        public bool is_business { get; set; }
        public bool is_closed { get; set; }
        public bool is_hidden { get; set; }
        public bool is_manual { get; set; }
        public int last_payment { get; set; }
        public DateTime last_payment_at { get; set; }
        public int loan_amount { get; set; }
        public DateTime matures_on { get; set; }
        public string member_guid { get; set; }
        public string member_id { get; set; }
        public bool member_is_managed_by_user { get; set; }
        public string metadata { get; set; }
        public int minimum_balance { get; set; }
        public int minimum_payment { get; set; }
        public string name { get; set; }
        public string nickname { get; set; }
        public int original_balance { get; set; }
        public int pay_out_amount { get; set; }
        public DateTime payment_due_at { get; set; }
        public int payoff_balance { get; set; }
        public int premium_amount { get; set; }
        public string property_type { get; set; }
        public string routing_number { get; set; }
        public DateTime started_on { get; set; }
        public string subtype { get; set; }
        public int total_account_value { get; set; }
        public string type { get; set; }
        public DateTime updated_at { get; set; }
        public string user_guid { get; set; }
        public string user_id { get; set; }
    }

    public class Account6
    {
        public string type { get; set; }
        public Properties properties { get; set; }
        public List<string> required { get; set; }
    }

    public class AccountGuid
    {
        public string type { get; set; }
        public string description { get; set; }
        public string example { get; set; }
    }

    public class AccountId
    {
        public string type { get; set; }
        public string description { get; set; }
    }

    public class AccountName
    {
        public string type { get; set; }
        public string description { get; set; }
        public string example { get; set; }
    }

    public class AccountNumber
    {
        public string account_guid { get; set; }
        public string account_number { get; set; }
        public string guid { get; set; }
        public string institution_number { get; set; }
        public string member_guid { get; set; }
        public bool passed_validation { get; set; }
        public string routing_number { get; set; }
        public string transit_number { get; set; }
        public string user_guid { get; set; }
    }

    public class AccountNumber2
    {
        public string type { get; set; }
        public string description { get; set; }
        public string example { get; set; }
    }

    public class AccountNumber6
    {
        public string type { get; set; }
        public Properties properties { get; set; }
    }

    public class AccountNumberGuid
    {
        public string type { get; set; }
        public string description { get; set; }
        public string example { get; set; }
    }

    public class AccountOwner
    {
        public string account_guid { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public string email { get; set; }
        public string first_name { get; set; }
        public string guid { get; set; }
        public string last_name { get; set; }
        public string member_guid { get; set; }
        public string owner_name { get; set; }
        public string phone { get; set; }
        public string postal_code { get; set; }
        public string state { get; set; }
        public string user_guid { get; set; }
    }

    public class AccountOwner2
    {
        public string type { get; set; }
        public Properties properties { get; set; }
    }

    public class Accounts
    {
        public Get get { get; set; }
    }

    public class AccountType
    {
        public string type { get; set; }
        public string description { get; set; }
        public string example { get; set; }
    }

    public class AccountVerification
    {
        public string type { get; set; }
        public Properties properties { get; set; }
    }

    public class Address
    {
        public string type { get; set; }
        public string description { get; set; }
        public string example { get; set; }
    }

    public class AggregatedAt
    {
        public string type { get; set; }
        public string description { get; set; }
    }

    public class Amount
    {
        public string type { get; set; }
        public string description { get; set; }
    }

    public class ApplicationJson
    {
        public Schema schema { get; set; }
        public Example example { get; set; }
    }

    public class Apr
    {
        public string type { get; set; }
        public string description { get; set; }
        public double example { get; set; }
    }

    public class Apy
    {
        public string type { get; set; }
        public string description { get; set; }
        public double example { get; set; }
    }

    public class AuthorizationCode
    {
        public Post post { get; set; }
    }

    public class AuthorizationCode2
    {
        public string code { get; set; }
    }

    public class AuthorizationCode3
    {
        public string type { get; set; }
        public Properties properties { get; set; }
    }

    public class AvailableBalance
    {
        public string type { get; set; }
        public string description { get; set; }
        public double example { get; set; }
    }

    public class AvailableCredit
    {
        public string type { get; set; }
        public string description { get; set; }
        public double example { get; set; }
    }

    public class BackgroundAggregationIsDisabled
    {
        public string type { get; set; }
        public string description { get; set; }
    }

    public class Balance
    {
        public string type { get; set; }
        public string description { get; set; }
        public double example { get; set; }
    }

    public class CashBalance
    {
        public string type { get; set; }
        public string description { get; set; }
        public double example { get; set; }
    }

    public class CashSurrenderValue
    {
        public string type { get; set; }
        public string description { get; set; }
        public double example { get; set; }
    }

    public class CategoriesCategoryGuid
    {
        public Get get { get; set; }
    }

    public class CategoriesDefault
    {
        public Get get { get; set; }
    }

    public class Category
    {
        public DateTime created_at { get; set; }
        public string guid { get; set; }
        public bool is_default { get; set; }
        public bool is_income { get; set; }
        public string metadata { get; set; }
        public string name { get; set; }
        public string parent_guid { get; set; }
        public DateTime updated_at { get; set; }
        public string type { get; set; }
        public string description { get; set; }
    }

    public class Category3
    {
        public DateTime created_at { get; set; }
        public string guid { get; set; }
        public bool is_default { get; set; }
        public bool is_income { get; set; }
        public string metadata { get; set; }
        public string name { get; set; }
        public string parent_guid { get; set; }
        public DateTime updated_at { get; set; }
    }

    public class Category6
    {
        public string type { get; set; }
        public Properties properties { get; set; }
        public List<string> required { get; set; }
    }

    public class CategoryGuid
    {
        public string type { get; set; }
        public string description { get; set; }
    }

    public class CheckNumberString
    {
        public string type { get; set; }
        public string description { get; set; }
    }

    public class City
    {
        public string type { get; set; }
        public string description { get; set; }
        public string example { get; set; }
    }

    public class Code
    {
        public string type { get; set; }
        public string description { get; set; }
    }

    public class Components
    {
        public Schemas schemas { get; set; }
        public SecuritySchemes securitySchemes { get; set; }
    }

    public class ConnectionStatus
    {
        public string type { get; set; }
        public string description { get; set; }
    }

    public class Content
    {
        [JsonProperty("application/json")]
        public ApplicationJson applicationjson { get; set; }
    }

    public class ContentHash
    {
        public string type { get; set; }
        public string description { get; set; }
    }

    public class CostBasis
    {
        public string type { get; set; }
        public string description { get; set; }
    }

    public class Country
    {
        public string type { get; set; }
        public string description { get; set; }
        public string example { get; set; }
    }

    public class CreatedAt
    {
        public string type { get; set; }
        public string description { get; set; }
        public DateTime example { get; set; }
    }

    public class Credential
    {
        public int display_order { get; set; }
        public string field_name { get; set; }
        public string field_type { get; set; }
        public string guid { get; set; }
        public string label { get; set; }
        public string type { get; set; }
    }

    public class Credential2
    {
        public string type { get; set; }
        public Properties properties { get; set; }
    }

    public class CreditLimit
    {
        public string type { get; set; }
        public string description { get; set; }
        public double example { get; set; }
    }

    public class CurrencyCode
    {
        public string type { get; set; }
        public string description { get; set; }
        public string example { get; set; }
    }

    public class Cusip
    {
        public string type { get; set; }
        public string description { get; set; }
    }

    public class DailyChange
    {
        public string type { get; set; }
        public string description { get; set; }
    }

    public class Date
    {
        public string type { get; set; }
        public string description { get; set; }
    }

    public class DayPaymentIsDue
    {
        public string type { get; set; }
        public string description { get; set; }
        public int example { get; set; }
    }

    public class DeathBenefit
    {
        public string type { get; set; }
        public string description { get; set; }
        public int example { get; set; }
    }

    public class Default
    {
        public string description { get; set; }
        public Content content { get; set; }
    }

    public class Delete
    {
        public List<string> tags { get; set; }
        public string operationId { get; set; }
        public List<Parameter> parameters { get; set; }
        public Responses responses { get; set; }
        public string description { get; set; }
        public string summary { get; set; }
    }

    public class Description
    {
        public string type { get; set; }
        public string description { get; set; }
    }

    public class DisplayOrder
    {
        public string type { get; set; }
        public string description { get; set; }
    }

    public class Email
    {
        public string type { get; set; }
        public string description { get; set; }
        public string example { get; set; }
    }

    public class Example
    {
        public List<Holding> holdings { get; set; }
        public Pagination pagination { get; set; }
        public Account account { get; set; }
        public List<AccountOwner> account_owners { get; set; }
        public AuthorizationCode authorization_code { get; set; }
        public List<Institution> institutions { get; set; }
        public Institution institution { get; set; }
        public MicroDeposit micro_deposit { get; set; }
        public List<AccountNumber> account_numbers { get; set; }
        public Category category { get; set; }
        public List<Credential> credentials { get; set; }
        public List<Category> categories { get; set; }
    }

    public class ExpiresAt
    {
        public string type { get; set; }
        public string description { get; set; }
    }

    public class FieldName
    {
        public string type { get; set; }
        public string description { get; set; }
    }

    public class FieldType
    {
        public string type { get; set; }
        public string description { get; set; }
    }

    public class FirstName
    {
        public string type { get; set; }
        public string description { get; set; }
        public string example { get; set; }
    }

    public class Get
    {
        public List<string> tags { get; set; }
        public string operationId { get; set; }
        public List<Parameter> parameters { get; set; }
        public Responses responses { get; set; }
        public string description { get; set; }
        public string summary { get; set; }
    }

    public class Guid
    {
        public string type { get; set; }
        public string description { get; set; }
        public string example { get; set; }
    }

    public class Holding
    {
        public string account_guid { get; set; }
        public int cost_basis { get; set; }
        public DateTime created_at { get; set; }
        public string currency_code { get; set; }
        public string cusip { get; set; }
        public double daily_change { get; set; }
        public string description { get; set; }
        public string guid { get; set; }
        public string holding_type { get; set; }
        public int holding_type_id { get; set; }
        public string id { get; set; }
        public double market_value { get; set; }
        public string member_guid { get; set; }
        public string metadata { get; set; }
        public double purchase_price { get; set; }
        public int shares { get; set; }
        public string symbol { get; set; }
        public DateTime updated_at { get; set; }
        public string user_guid { get; set; }
    }

    public class Holding2
    {
        public string type { get; set; }
        public Properties properties { get; set; }
        public string description { get; set; }
    }

    public class HoldingsValue
    {
        public string type { get; set; }
        public string description { get; set; }
        public double example { get; set; }
    }

    public class HoldingType
    {
        public string type { get; set; }
        public string description { get; set; }
    }

    public class HoldingTypeId
    {
        public string type { get; set; }
        public string description { get; set; }
    }

    public class Id
    {
        public string type { get; set; }
        public string description { get; set; }
        public string example { get; set; }
    }

    public class ImportedAt
    {
        public string type { get; set; }
        public string description { get; set; }
        public DateTime example { get; set; }
    }

    public class Info
    {
        public string title { get; set; }
        public string description { get; set; }
        public string version { get; set; }
    }

    public class Institution
    {
        public string code { get; set; }
        public string forgot_password_url { get; set; }
        public string forgot_username_url { get; set; }
        public string instructional_text { get; set; }
        public string medium_logo_url { get; set; }
        public string name { get; set; }
        public string small_logo_url { get; set; }
        public bool supports_account_identification { get; set; }
        public bool supports_account_statement { get; set; }
        public bool supports_account_verification { get; set; }
        public bool supports_oauth { get; set; }
        public bool supports_transaction_history { get; set; }
        public string trouble_signing_in_url { get; set; }
        public string url { get; set; }
    }

    public class Institution4
    {
        public string code { get; set; }
        public string forgot_password_url { get; set; }
        public string forgot_username_url { get; set; }
        public string instructional_text { get; set; }
        public string medium_logo_url { get; set; }
        public string name { get; set; }
        public string small_logo_url { get; set; }
        public bool supports_account_identification { get; set; }
        public bool supports_account_statement { get; set; }
        public bool supports_account_verification { get; set; }
        public bool supports_oauth { get; set; }
        public bool supports_transaction_history { get; set; }
        public string trouble_signing_in_url { get; set; }
        public string url { get; set; }
    }

    public class Institution5
    {
        public string type { get; set; }
        public Properties properties { get; set; }
    }

    public class InstitutionCode
    {
        public string type { get; set; }
        public string description { get; set; }
        public string example { get; set; }
    }

    public class InstitutionName
    {
        public string type { get; set; }
        public string description { get; set; }
        public string example { get; set; }
    }

    public class InstitutionNumber
    {
        public string type { get; set; }
        public string description { get; set; }
        public string example { get; set; }
    }

    public class Institutions
    {
        public Get get { get; set; }
    }

    public class InstitutionsFavorites
    {
        public Get get { get; set; }
    }

    public class InstitutionsInstitutionCode
    {
        public Get get { get; set; }
    }

    public class InstitutionsInstitutionCodeCredentials
    {
        public Get get { get; set; }
    }

    public class InstructionalText
    {
        public string type { get; set; }
        public string description { get; set; }
    }

    public class InsuredName
    {
        public string type { get; set; }
        public string description { get; set; }
        public string example { get; set; }
    }

    public class InterestRate
    {
        public string type { get; set; }
        public string description { get; set; }
        public double example { get; set; }
    }

    public class IsBeingAggregated
    {
        public string type { get; set; }
        public string description { get; set; }
    }

    public class IsBillPay
    {
        public string type { get; set; }
        public string description { get; set; }
    }

    public class IsClosed
    {
        public string type { get; set; }
        public string description { get; set; }
    }

    public class IsDefault
    {
        public string type { get; set; }
        public string description { get; set; }
    }

    public class IsDirectDeposit
    {
        public string type { get; set; }
        public string description { get; set; }
    }

    public class IsDisabled
    {
        public string type { get; set; }
        public string description { get; set; }
    }

    public class IsExpense
    {
        public string type { get; set; }
        public string description { get; set; }
    }

    public class IsFee
    {
        public string type { get; set; }
        public string description { get; set; }
    }

    public class IsHidden
    {
        public string type { get; set; }
        public string description { get; set; }
    }

    public class IsIncome
    {
        public string type { get; set; }
        public string description { get; set; }
    }

    public class IsInternational
    {
        public string type { get; set; }
        public string description { get; set; }
    }

    public class IsManagedByUser
    {
        public string type { get; set; }
        public string description { get; set; }
    }

    public class IsOauth
    {
        public string type { get; set; }
        public string description { get; set; }
    }

    public class IsOverdraftFee
    {
        public string type { get; set; }
        public string description { get; set; }
    }

    public class IsPayrollAdvance
    {
        public string type { get; set; }
        public string description { get; set; }
    }

    public class IsRecurring
    {
        public string type { get; set; }
        public string description { get; set; }
    }

    public class IsSubscription
    {
        public string type { get; set; }
        public string description { get; set; }
    }

    public class Items
    {
        [JsonProperty("$ref")]
        public string @ref { get; set; }
    }

    public class Label
    {
        public string type { get; set; }
        public string description { get; set; }
    }

    public class LastName
    {
        public string type { get; set; }
        public string description { get; set; }
        public string example { get; set; }
    }

    public class LastPayment
    {
        public string type { get; set; }
        public string description { get; set; }
        public double example { get; set; }
    }

    public class LastPaymentAt
    {
        public string type { get; set; }
        public string description { get; set; }
        public DateTime example { get; set; }
    }

    public class Latitude
    {
        public string type { get; set; }
        public string description { get; set; }
    }

    public class LoanAmount
    {
        public string type { get; set; }
        public string description { get; set; }
        public double example { get; set; }
    }

    public class LocalizedDescription
    {
        public string type { get; set; }
        public string description { get; set; }
    }

    public class LocalizedMemo
    {
        public string type { get; set; }
        public string description { get; set; }
    }

    public class LogoUpdatedAt
    {
        public string type { get; set; }
        public string description { get; set; }
    }

    public class LogoUrl
    {
        public string type { get; set; }
        public string description { get; set; }
    }

    public class Longitude
    {
        public string type { get; set; }
        public string description { get; set; }
    }

    public class ManagedInstitutions
    {
        public Get get { get; set; }
    }

    public class MarketValue
    {
        public string type { get; set; }
        public string description { get; set; }
    }

    public class MatchDescription
    {
        public string type { get; set; }
        public string description { get; set; }
    }

    public class MaturesOn
    {
        public string type { get; set; }
        public string description { get; set; }
        public DateTime example { get; set; }
    }

    public class MediumLogoUrl
    {
        public string type { get; set; }
        public string description { get; set; }
    }

    public class Member
    {
        public string type { get; set; }
        public Properties properties { get; set; }
    }

    public class MemberGuid
    {
        public string type { get; set; }
        public string description { get; set; }
        public string example { get; set; }
    }

    public class MemberId
    {
        public string type { get; set; }
        public string description { get; set; }
        public string example { get; set; }
    }

    public class MemberIsManagedByUser
    {
        public string type { get; set; }
        public string description { get; set; }
    }

    public class Memo
    {
        public string type { get; set; }
        public string description { get; set; }
    }

    public class Merchant
    {
        public string type { get; set; }
        public Properties properties { get; set; }
        public string description { get; set; }
    }

    public class MerchantCategoryCode
    {
        public string type { get; set; }
        public string description { get; set; }
    }

    public class MerchantGuid
    {
        public string type { get; set; }
        public string description { get; set; }
    }

    public class MerchantLocation
    {
        public string type { get; set; }
        public Properties properties { get; set; }
        public string description { get; set; }
    }

    public class MerchantLocationGuid
    {
        public string type { get; set; }
        public string description { get; set; }
    }

    public class MerchantLocationsMerchantLocationGuid
    {
        public Get get { get; set; }
    }

    public class Merchants
    {
        public Get get { get; set; }
    }

    public class MerchantsMerchantGuid
    {
        public Get get { get; set; }
    }

    public class Metadata
    {
        public string type { get; set; }
        public string description { get; set; }
        public string example { get; set; }
    }

    public class MicroDeposit
    {
        public string account_name { get; set; }
        public string account_number { get; set; }
        public string account_type { get; set; }
        public DateTime created_at { get; set; }
        public string email { get; set; }
        public object error_code { get; set; }
        public object error_message { get; set; }
        public string first_name { get; set; }
        public string guid { get; set; }
        public object institution_code { get; set; }
        public object institution_name { get; set; }
        public string last_name { get; set; }
        public string routing_number { get; set; }
        public string status { get; set; }
        public DateTime updated_at { get; set; }
        public object verified_at { get; set; }
    }

    public class MicroDeposit2
    {
        public string type { get; set; }
        public Properties properties { get; set; }
    }

    public class MicroDepositGuid
    {
        public string type { get; set; }
        public string description { get; set; }
        public string example { get; set; }
    }

    public class MinimumBalance
    {
        public string type { get; set; }
        public string description { get; set; }
        public double example { get; set; }
    }

    public class MinimumPayment
    {
        public string type { get; set; }
        public string description { get; set; }
        public double example { get; set; }
    }

    public class Name
    {
        public string type { get; set; }
        public string description { get; set; }
        public string example { get; set; }
    }

    public class Nickname
    {
        public string type { get; set; }
        public string description { get; set; }
        public string example { get; set; }
    }

    public class OriginalBalance
    {
        public string type { get; set; }
        public string description { get; set; }
        public double example { get; set; }
    }

    public class OriginalDescription
    {
        public string type { get; set; }
        public string description { get; set; }
    }

    public class OwnerName
    {
        public string type { get; set; }
        public string description { get; set; }
        public string example { get; set; }
    }

    public class Pagination
    {
        public int current_page { get; set; }
        public int per_page { get; set; }
        public int total_entries { get; set; }
        public int total_pages { get; set; }
    }

    public class Parameter
    {
        public string name { get; set; }
        public string description { get; set; }
        public bool required { get; set; }
        public string @in { get; set; }
        public Schema schema { get; set; }
        public bool explode { get; set; }
    }

    public class ParentGuid
    {
        public string type { get; set; }
        public string description { get; set; }
    }

    public class PassedValidation
    {
        public string type { get; set; }
        public string description { get; set; }
        public bool example { get; set; }
    }

    public class Paths
    {
        [JsonProperty("/users/{user_guid}/holdings")]
        public UsersUserGuidHoldings usersuser_guidholdings { get; set; }

        [JsonProperty("/token")]
        public Token token { get; set; }

        [JsonProperty("/users/{user_guid}/categories/{category_guid}")]
        public UsersUserGuidCategoriesCategoryGuid usersuser_guidcategoriescategory_guid { get; set; }

        [JsonProperty("/categories/default")]
        public CategoriesDefault categoriesdefault { get; set; }

        [JsonProperty("/categories/{category_guid}")]
        public CategoriesCategoryGuid categoriescategory_guid { get; set; }

        [JsonProperty("/user/{user_guid}/categories")]
        public UserUserGuidCategories useruser_guidcategories { get; set; }

        [JsonProperty("/managed_institutions")]
        public ManagedInstitutions managed_institutions { get; set; }

        [JsonProperty("/merchant_locations/{merchant_location_guid}")]
        public MerchantLocationsMerchantLocationGuid merchant_locationsmerchant_location_guid { get; set; }

        [JsonProperty("/users/{user_guid}/members/{member_guid}/statements")]
        public UsersUserGuidMembersMemberGuidStatements usersuser_guidmembersmember_guidstatements { get; set; }

        [JsonProperty("/users/{user_guid}/members/{member_guid}/statements/{statement_guid}")]
        public UsersUserGuidMembersMemberGuidStatementsStatementGuid usersuser_guidmembersmember_guidstatementsstatement_guid { get; set; }

        [JsonProperty("/users/{user_guid}/tags")]
        public UsersUserGuidTags usersuser_guidtags { get; set; }

        [JsonProperty("/users/{user_guid}/tags/{tag_guid}")]
        public UsersUserGuidTagsTagGuid usersuser_guidtagstag_guid { get; set; }

        [JsonProperty("/merchants")]
        public Merchants merchants { get; set; }

        [JsonProperty("/merchants/{merchant_guid}")]
        public MerchantsMerchantGuid merchantsmerchant_guid { get; set; }

        [JsonProperty("/users/{user_guid}/managed_members")]
        public UsersUserGuidManagedMembers usersuser_guidmanaged_members { get; set; }

        [JsonProperty("/users/{user_guid}/managed_members/{member_guid}")]
        public UsersUserGuidManagedMembersMemberGuid usersuser_guidmanaged_membersmember_guid { get; set; }

        [JsonProperty("/users/{user_guid}/managed_members/{member_guid}/accounts")]
        public UsersUserGuidManagedMembersMemberGuidAccounts usersuser_guidmanaged_membersmember_guidaccounts { get; set; }

        [JsonProperty("/uses/{user_guid}/managed_members/{member_guid}/accounts/{account_guid}")]
        public UsesUserGuidManagedMembersMemberGuidAccountsAccountGuid usesuser_guidmanaged_membersmember_guidaccountsaccount_guid { get; set; }

        [JsonProperty("/users/{user_guid}/managed_members/{member_guid}/accounts/{account_guid}")]
        public UsersUserGuidManagedMembersMemberGuidAccountsAccountGuid usersuser_guidmanaged_membersmember_guidaccountsaccount_guid { get; set; }

        [JsonProperty("/users/{user_guid}/members/{member_guid}/account_owners")]
        public UsersUserGuidMembersMemberGuidAccountOwners usersuser_guidmembersmember_guidaccount_owners { get; set; }

        [JsonProperty("/authorization_code")]
        public AuthorizationCode authorization_code { get; set; }

        [JsonProperty("/payment_account")]
        public PaymentAccount payment_account { get; set; }

        [JsonProperty("/users/{user_guid}/managed_members/{managed_member_guid}/accounts/{account_guid}/transactions")]
        public UsersUserGuidManagedMembersManagedMemberGuidAccountsAccountGuidTransactions usersuser_guidmanaged_membersmanaged_member_guidaccountsaccount_guidtransactions { get; set; }

        [JsonProperty("/users/{user_guid}/managed_members/{managed_member_guid}/accounts/{account_guid}/transactions/{transaction_guid}")]
        public UsersUserGuidManagedMembersManagedMemberGuidAccountsAccountGuidTransactionsTransactionGuid usersuser_guidmanaged_membersmanaged_member_guidaccountsaccount_guidtransactionstransaction_guid { get; set; }

        [JsonProperty("/users")]
        public Users users { get; set; }

        [JsonProperty("/users/{user_guid}")]
        public UsersUserGuid usersuser_guid { get; set; }

        [JsonProperty("/institutions/favorites")]
        public InstitutionsFavorites institutionsfavorites { get; set; }

        [JsonProperty("/institutions")]
        public Institutions institutions { get; set; }

        [JsonProperty("/institutions/{institution_code}")]
        public InstitutionsInstitutionCode institutionsinstitution_code { get; set; }

        [JsonProperty("/users/{user_guid}/transactions/{transaction_guid}")]
        public UsersUserGuidTransactionsTransactionGuid usersuser_guidtransactionstransaction_guid { get; set; }

        [JsonProperty("/users/{user_guid}/members")]
        public UsersUserGuidMembers usersuser_guidmembers { get; set; }

        [JsonProperty("/users/{user_guid}/members/{member_guid}/credentials")]
        public UsersUserGuidMembersMemberGuidCredentials usersuser_guidmembersmember_guidcredentials { get; set; }

        [JsonProperty("/users/{user_guid}/members/{member_guid}/challenges")]
        public UsersUserGuidMembersMemberGuidChallenges usersuser_guidmembersmember_guidchallenges { get; set; }

        [JsonProperty("/users/{user_guid}/members/{member_guid}")]
        public UsersUserGuidMembersMemberGuid usersuser_guidmembersmember_guid { get; set; }

        [JsonProperty("/users/{user_guid}/members/{member_guid}/oauth_window_uri")]
        public UsersUserGuidMembersMemberGuidOauthWindowUri usersuser_guidmembersmember_guidoauth_window_uri { get; set; }

        [JsonProperty("/users/{user_guid}/members/{member_guid}/status")]
        public UsersUserGuidMembersMemberGuidStatus usersuser_guidmembersmember_guidstatus { get; set; }

        [JsonProperty("/users/{user_guid}/micro_deposits/{micro_deposit_guid}")]
        public UsersUserGuidMicroDepositsMicroDepositGuid usersuser_guidmicro_depositsmicro_deposit_guid { get; set; }

        [JsonProperty("/accounts")]
        public Accounts accounts { get; set; }

        [JsonProperty("/users/{user_guid}/members/{member_guid}/accounts/{account_guid}")]
        public UsersUserGuidMembersMemberGuidAccountsAccountGuid usersuser_guidmembersmember_guidaccountsaccount_guid { get; set; }

        [JsonProperty("/users/{user_id}/accounts/{account_id}/account_numbers")]
        public UsersUserIdAccountsAccountIdAccountNumbers usersuser_idaccountsaccount_idaccount_numbers { get; set; }

        [JsonProperty("/users/{user_guid}/taggings")]
        public UsersUserGuidTaggings usersuser_guidtaggings { get; set; }

        [JsonProperty("/users/{user_guid}/taggings/{tagging_guid}")]
        public UsersUserGuidTaggingsTaggingGuid usersuser_guidtaggingstagging_guid { get; set; }

        [JsonProperty("/institutions/{institution_code}/credentials")]
        public InstitutionsInstitutionCodeCredentials institutionsinstitution_codecredentials { get; set; }
    }

    public class PaymentAccount
    {
        public Get get { get; set; }
    }

    public class PaymentAccount2
    {
        public string type { get; set; }
        public Properties properties { get; set; }
    }

    public class PaymentDueAt
    {
        public string type { get; set; }
        public string description { get; set; }
        public DateTime example { get; set; }
    }

    public class PayoffBalance
    {
        public string type { get; set; }
        public string description { get; set; }
        public double example { get; set; }
    }

    public class PayOutAmount
    {
        public string type { get; set; }
        public string description { get; set; }
        public double example { get; set; }
    }

    public class Phone
    {
        public string type { get; set; }
        public string description { get; set; }
        public string example { get; set; }
    }

    public class PhoneNumber
    {
        public string type { get; set; }
        public string description { get; set; }
    }

    public class Post
    {
        public List<string> tags { get; set; }
        public string operationId { get; set; }
        public List<Parameter> parameters { get; set; }
        public Responses responses { get; set; }
        public string description { get; set; }
        public string summary { get; set; }
        public RequestBody requestBody { get; set; }
    }

    public class PostalCode
    {
        public string type { get; set; }
        public string description { get; set; }
        public string example { get; set; }
    }

    public class PostedAt
    {
        public string type { get; set; }
        public string description { get; set; }
    }

    public class PremiumAmount
    {
        public string type { get; set; }
        public string description { get; set; }
        public double example { get; set; }
    }

    public class Properties
    {
        public DisplayOrder display_order { get; set; }
        public FieldName field_name { get; set; }
        public FieldType field_type { get; set; }
        public Guid guid { get; set; }
        public Label label { get; set; }
        public Type type { get; set; }
        public AggregatedAt aggregated_at { get; set; }
        public BackgroundAggregationIsDisabled background_aggregation_is_disabled { get; set; }
        public ConnectionStatus connection_status { get; set; }
        public Id id { get; set; }
        public InstitutionCode institution_code { get; set; }
        public IsBeingAggregated is_being_aggregated { get; set; }
        public IsManagedByUser is_managed_by_user { get; set; }
        public IsOauth is_oauth { get; set; }
        public Metadata metadata { get; set; }
        public Name name { get; set; }
        public SuccessfullyAggregatedAt successfully_aggregated_at { get; set; }
        public UserGuid user_guid { get; set; }
        public UserId user_id { get; set; }
        public CategoryGuid category_guid { get; set; }
        public CreatedAt created_at { get; set; }
        public Description description { get; set; }
        public MatchDescription match_description { get; set; }
        public UpdatedAt updated_at { get; set; }
        public AccountGuid account_guid { get; set; }
        public AccountId account_id { get; set; }
        public Amount amount { get; set; }
        public Category category { get; set; }
        public CheckNumberString check_number_string { get; set; }
        public CurrencyCode currency_code { get; set; }
        public Date date { get; set; }
        public IsBillPay is_bill_pay { get; set; }
        public IsDirectDeposit is_direct_deposit { get; set; }
        public IsExpense is_expense { get; set; }
        public IsFee is_fee { get; set; }
        public IsIncome is_income { get; set; }
        public IsInternational is_international { get; set; }
        public IsOverdraftFee is_overdraft_fee { get; set; }
        public IsPayrollAdvance is_payroll_advance { get; set; }
        public IsRecurring is_recurring { get; set; }
        public IsSubscription is_subscription { get; set; }
        public Latitude latitude { get; set; }
        public LocalizedDescription localized_description { get; set; }
        public LocalizedMemo localized_memo { get; set; }
        public Longitude longitude { get; set; }
        public MemberGuid member_guid { get; set; }
        public MemberIsManagedByUser member_is_managed_by_user { get; set; }
        public Memo memo { get; set; }
        public MerchantCategoryCode merchant_category_code { get; set; }
        public MerchantGuid merchant_guid { get; set; }
        public MerchantLocationGuid merchant_location_guid { get; set; }
        public OriginalDescription original_description { get; set; }
        public PostedAt posted_at { get; set; }
        public Status status { get; set; }
        public TopLevelCategory top_level_category { get; set; }
        public TransactedAt transacted_at { get; set; }
        public ContentHash content_hash { get; set; }
        public Url url { get; set; }
        public CostBasis cost_basis { get; set; }
        public Cusip cusip { get; set; }
        public DailyChange daily_change { get; set; }
        public HoldingType holding_type { get; set; }
        public HoldingTypeId holding_type_id { get; set; }
        public MarketValue market_value { get; set; }
        public PurchasePrice purchase_price { get; set; }
        public Shares shares { get; set; }
        public Symbol symbol { get; set; }
        public AccessToken access_token { get; set; }
        public ExpiresAt expires_at { get; set; }
        public Scope scope { get; set; }
        public TokenType token_type { get; set; }
        public AccountNumber account_number { get; set; }
        public AccountType account_type { get; set; }
        public Email email { get; set; }
        public FirstName first_name { get; set; }
        public InstitutionName institution_name { get; set; }
        public LastName last_name { get; set; }
        public RoutingNumber routing_number { get; set; }
        public VerifiedAt verified_at { get; set; }
        public Code code { get; set; }
        public InstructionalText instructional_text { get; set; }
        public MediumLogoUrl medium_logo_url { get; set; }
        public SmallLogoUrl small_logo_url { get; set; }
        public SupportsAccountIdentification supports_account_identification { get; set; }
        public SupportsAccountStatement supports_account_statement { get; set; }
        public SupportsAccountVerification supports_account_verification { get; set; }
        public SupportsOauth supports_oauth { get; set; }
        public SupportsTransactionHistory supports_transaction_history { get; set; }
        public LogoUrl logo_url { get; set; }
        public LogoUpdatedAt logo_updated_at { get; set; }
        public WebsiteUrl website_url { get; set; }
        public City city { get; set; }
        public Country country { get; set; }
        public PhoneNumber phone_number { get; set; }
        public PostalCode postal_code { get; set; }
        public State state { get; set; }
        public StreetAddress street_address { get; set; }
        public Apr apr { get; set; }
        public Apy apy { get; set; }
        public AvailableBalance available_balance { get; set; }
        public AvailableCredit available_credit { get; set; }
        public Balance balance { get; set; }
        public CashBalance cash_balance { get; set; }
        public CashSurrenderValue cash_surrender_value { get; set; }
        public CreditLimit credit_limit { get; set; }
        public DayPaymentIsDue day_payment_is_due { get; set; }
        public DeathBenefit death_benefit { get; set; }
        public HoldingsValue holdings_value { get; set; }
        public ImportedAt imported_at { get; set; }
        public InsuredName insured_name { get; set; }
        public InterestRate interest_rate { get; set; }
        public IsClosed is_closed { get; set; }
        public IsHidden is_hidden { get; set; }
        public LastPaymentAt last_payment_at { get; set; }
        public LastPayment last_payment { get; set; }
        public LoanAmount loan_amount { get; set; }
        public MaturesOn matures_on { get; set; }
        public MemberId member_id { get; set; }
        public MinimumBalance minimum_balance { get; set; }
        public MinimumPayment minimum_payment { get; set; }
        public Nickname nickname { get; set; }
        public OriginalBalance original_balance { get; set; }
        public PayOutAmount pay_out_amount { get; set; }
        public PaymentDueAt payment_due_at { get; set; }
        public PayoffBalance payoff_balance { get; set; }
        public PremiumAmount premium_amount { get; set; }
        public StartedOn started_on { get; set; }
        public Subtype subtype { get; set; }
        public TotalAccountValue total_account_value { get; set; }
        public IsDisabled is_disabled { get; set; }
        public InstitutionNumber institution_number { get; set; }
        public PassedValidation passed_validation { get; set; }
        public TransitNumber transit_number { get; set; }
        public IsDefault is_default { get; set; }
        public ParentGuid parent_guid { get; set; }
        public TagGuid tag_guid { get; set; }
        public TransactionGuid transaction_guid { get; set; }
        public AccountName account_name { get; set; }
        public Address address { get; set; }
        public OwnerName owner_name { get; set; }
        public Phone phone { get; set; }
        public AccountNumberGuid account_number_guid { get; set; }
        public MicroDepositGuid micro_deposit_guid { get; set; }
        public VerificationMethod verification_method { get; set; }
    }

    public class PurchasePrice
    {
        public string type { get; set; }
        public string description { get; set; }
    }

    public class Put
    {
        public List<string> tags { get; set; }
        public string operationId { get; set; }
        public List<Parameter> parameters { get; set; }
        public Responses responses { get; set; }
        public string description { get; set; }
        public string summary { get; set; }
        public RequestBody requestBody { get; set; }
    }

    public class RequestBody
    {
        public string description { get; set; }
        public Content content { get; set; }
    }

    public class Responses
    {
        public Default @default { get; set; }

        [JsonProperty("200")]
        public _200 _200 { get; set; }

        [JsonProperty("204")]
        public _204 _204 { get; set; }

        [JsonProperty("409")]
        public _409 _409 { get; set; }
    }

    public class Root
    {
        public string openapi { get; set; }
        public Info info { get; set; }
        public List<Server> servers { get; set; }
        public Paths paths { get; set; }
        public List<Tag> tags { get; set; }
        public Components components { get; set; }
    }

    public class RoutingNumber
    {
        public string type { get; set; }
        public string description { get; set; }
        public string example { get; set; }
    }

    public class Schema
    {
        public string type { get; set; }

        [JsonProperty("$ref")]
        public string @ref { get; set; }
        public Items items { get; set; }
    }

    public class Schemas
    {
        public Credential Credential { get; set; }
        public Account Account { get; set; }
        public Category Category { get; set; }
        public Tag Tag { get; set; }
        public Tagging Tagging { get; set; }
        public AuthorizationCode AuthorizationCode { get; set; }
        public PaymentAccount PaymentAccount { get; set; }
        public AccountOwner AccountOwner { get; set; }
        public AccountVerification AccountVerification { get; set; }
        public Member Member { get; set; }
        public UserTransactionRule UserTransactionRule { get; set; }
        public Transaction Transaction { get; set; }
        public Statement Statement { get; set; }
        public Holding Holding { get; set; }
        public Token Token { get; set; }
        public MicroDeposit MicroDeposit { get; set; }
        public Institution Institution { get; set; }
        public Merchant Merchant { get; set; }
        public MerchantLocation MerchantLocation { get; set; }
        public User User { get; set; }
        public AccountNumber AccountNumber { get; set; }
    }

    public class Scope
    {
        public string type { get; set; }
        public string description { get; set; }
    }

    public class SecuritySchemes
    {
    }

    public class Server
    {
        public string url { get; set; }
    }

    public class Shares
    {
        public string type { get; set; }
        public string description { get; set; }
    }

    public class SmallLogoUrl
    {
        public string type { get; set; }
        public string description { get; set; }
    }

    public class StartedOn
    {
        public string type { get; set; }
        public string description { get; set; }
        public DateTime example { get; set; }
    }

    public class State
    {
        public string type { get; set; }
        public string description { get; set; }
        public string example { get; set; }
    }

    public class Statement
    {
        public string type { get; set; }
        public Properties properties { get; set; }
    }

    public class Status
    {
        public string type { get; set; }
        public string description { get; set; }
    }

    public class StreetAddress
    {
        public string type { get; set; }
        public string description { get; set; }
    }

    public class Subtype
    {
        public string type { get; set; }
        public string description { get; set; }
        public string example { get; set; }
    }

    public class SuccessfullyAggregatedAt
    {
        public string type { get; set; }
        public string description { get; set; }
    }

    public class SupportsAccountIdentification
    {
        public string type { get; set; }
        public string description { get; set; }
    }

    public class SupportsAccountStatement
    {
        public string type { get; set; }
        public string description { get; set; }
    }

    public class SupportsAccountVerification
    {
        public string type { get; set; }
        public string description { get; set; }
    }

    public class SupportsOauth
    {
        public string type { get; set; }
        public string description { get; set; }
    }

    public class SupportsTransactionHistory
    {
        public string type { get; set; }
        public string description { get; set; }
    }

    public class Symbol
    {
        public string type { get; set; }
        public string description { get; set; }
    }

    public class Tag
    {
        public string name { get; set; }
        public string description { get; set; }
    }

    public class Tag2
    {
        public string type { get; set; }
        public Properties properties { get; set; }
    }

    public class Tagging
    {
        public string type { get; set; }
        public Properties properties { get; set; }
    }

    public class TagGuid
    {
        public string type { get; set; }
        public string description { get; set; }
    }

    public class Token
    {
        public Post post { get; set; }
    }

    public class Token2
    {
        public string type { get; set; }
        public Properties properties { get; set; }
    }

    public class TokenType
    {
        public string type { get; set; }
        public string description { get; set; }
    }

    public class TopLevelCategory
    {
        public string type { get; set; }
        public string description { get; set; }
    }

    public class TotalAccountValue
    {
        public string type { get; set; }
        public string description { get; set; }
        public double example { get; set; }
    }

    public class TransactedAt
    {
        public string type { get; set; }
        public string description { get; set; }
    }

    public class Transaction
    {
        public string type { get; set; }
        public Properties properties { get; set; }
    }

    public class TransactionGuid
    {
        public string type { get; set; }
        public string description { get; set; }
    }

    public class TransitNumber
    {
        public string type { get; set; }
        public string description { get; set; }
        public string example { get; set; }
    }

    public class Type
    {
        public string type { get; set; }
        public string description { get; set; }
        public string example { get; set; }
    }

    public class UpdatedAt
    {
        public string type { get; set; }
        public string description { get; set; }
        public DateTime example { get; set; }
    }

    public class Url
    {
        public string type { get; set; }
        public string description { get; set; }
    }

    public class User
    {
        public string type { get; set; }
        public Properties properties { get; set; }
    }

    public class UserGuid
    {
        public string type { get; set; }
        public string description { get; set; }
        public string example { get; set; }
    }

    public class UserId
    {
        public string type { get; set; }
        public string description { get; set; }
        public string example { get; set; }
    }

    public class Users
    {
        public Post post { get; set; }
        public Get get { get; set; }
    }

    public class UsersUserGuid
    {
        public Delete delete { get; set; }
        public Get get { get; set; }
        public Put put { get; set; }
    }

    public class UsersUserGuidCategoriesCategoryGuid
    {
        public Get get { get; set; }
        public Delete delete { get; set; }
        public Put put { get; set; }
    }

    public class UsersUserGuidHoldings
    {
        public Get get { get; set; }
    }

    public class UsersUserGuidManagedMembers
    {
        public Get get { get; set; }
        public Post post { get; set; }
    }

    public class UsersUserGuidManagedMembersManagedMemberGuidAccountsAccountGuidTransactions
    {
        public Post post { get; set; }
        public Get get { get; set; }
    }

    public class UsersUserGuidManagedMembersManagedMemberGuidAccountsAccountGuidTransactionsTransactionGuid
    {
        public Delete delete { get; set; }
        public Get get { get; set; }
        public Put put { get; set; }
    }

    public class UsersUserGuidManagedMembersMemberGuid
    {
        public Get get { get; set; }
        public Put put { get; set; }
        public Delete delete { get; set; }
    }

    public class UsersUserGuidManagedMembersMemberGuidAccounts
    {
        public Post post { get; set; }
        public Get get { get; set; }
    }

    public class UsersUserGuidManagedMembersMemberGuidAccountsAccountGuid
    {
        public Get get { get; set; }
        public Put put { get; set; }
    }

    public class UsersUserGuidMembers
    {
        public Post post { get; set; }
    }

    public class UsersUserGuidMembersMemberGuid
    {
        public Delete delete { get; set; }
        public Put put { get; set; }
    }

    public class UsersUserGuidMembersMemberGuidAccountOwners
    {
        public Get get { get; set; }
    }

    public class UsersUserGuidMembersMemberGuidAccountsAccountGuid
    {
        public Put put { get; set; }
    }

    public class UsersUserGuidMembersMemberGuidChallenges
    {
        public Get get { get; set; }
    }

    public class UsersUserGuidMembersMemberGuidCredentials
    {
        public Get get { get; set; }
    }

    public class UsersUserGuidMembersMemberGuidOauthWindowUri
    {
        public Get get { get; set; }
    }

    public class UsersUserGuidMembersMemberGuidStatements
    {
        public Get get { get; set; }
    }

    public class UsersUserGuidMembersMemberGuidStatementsStatementGuid
    {
        public Get get { get; set; }
    }

    public class UsersUserGuidMembersMemberGuidStatus
    {
        public Get get { get; set; }
    }

    public class UsersUserGuidMicroDepositsMicroDepositGuid
    {
        public Get get { get; set; }
    }

    public class UsersUserGuidTaggings
    {
        public Post post { get; set; }
        public Get get { get; set; }
    }

    public class UsersUserGuidTaggingsTaggingGuid
    {
        public Delete delete { get; set; }
        public Get get { get; set; }
        public Put put { get; set; }
    }

    public class UsersUserGuidTags
    {
        public Post post { get; set; }
        public Get get { get; set; }
    }

    public class UsersUserGuidTagsTagGuid
    {
        public Delete delete { get; set; }
        public Get get { get; set; }
        public Put put { get; set; }
    }

    public class UsersUserGuidTransactionsTransactionGuid
    {
        public Put put { get; set; }
    }

    public class UsersUserIdAccountsAccountIdAccountNumbers
    {
        public Get get { get; set; }
    }

    public class UserTransactionRule
    {
        public string type { get; set; }
        public Properties properties { get; set; }
    }

    public class UserUserGuidCategories
    {
        public Post post { get; set; }
    }

    public class UsesUserGuidManagedMembersMemberGuidAccountsAccountGuid
    {
        public Delete delete { get; set; }
    }

    public class VerificationMethod
    {
        public string type { get; set; }
        public string description { get; set; }
        public string example { get; set; }
    }

    public class VerifiedAt
    {
        public string type { get; set; }
        public string description { get; set; }
        public DateTime example { get; set; }
    }

    public class WebsiteUrl
    {
        public string type { get; set; }
        public string description { get; set; }
    }

