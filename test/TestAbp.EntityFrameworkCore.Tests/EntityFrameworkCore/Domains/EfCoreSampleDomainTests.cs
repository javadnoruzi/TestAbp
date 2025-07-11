using TestAbp.Samples;
using Xunit;

namespace TestAbp.EntityFrameworkCore.Domains;

[Collection(TestAbpTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<TestAbpEntityFrameworkCoreTestModule>
{

}
