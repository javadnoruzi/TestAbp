using TestAbp.Samples;
using Xunit;

namespace TestAbp.EntityFrameworkCore.Applications;

[Collection(TestAbpTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<TestAbpEntityFrameworkCoreTestModule>
{

}
