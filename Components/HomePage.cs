using Atata;

namespace AtataSpecFlowPOC.SpecFlow.Components;

using _ = HomePage;

public class HomePage : BasePage<_>
{
    public H1<_> Header { get; private set; }
}
