using Xunit;

namespace TestAbp.EntityFrameworkCore;

[CollectionDefinition(TestAbpTestConsts.CollectionDefinitionName)]
public class TestAbpEntityFrameworkCoreCollection : ICollectionFixture<TestAbpEntityFrameworkCoreFixture>
{

}
