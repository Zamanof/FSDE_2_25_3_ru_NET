// Derived < Base
// Child < Base
// Derived is Base
// Child is Base
Base @base = new();
Derived derived = new();
Child child = new();

// Reference to Base class
Base derived2 = new Derived();

//derived2.Show();
//@base.Show();
//derived.Show();
//child.Show();

//Foo(@base);
//Foo(derived);
//Foo(child);
//Base[] arr = [@base, derived, child];
//foreach (var item in arr)
//{
//    item.Show();
//    (item as Derived)?.Print();
//    //Derived value = item as Derived;
//    //value?.Print();
//}


void Foo(Base @base)
{
    #region version 1
    //if (@base.GetType() == new Derived().GetType())
    //{
    //    ((Derived)@base).Show();
    //}
    //else if (@base.GetType() == new Child().GetType())
    //{
    //    ((Child)@base).Show();
    //}
    //else
    //{
    //    @base.Show();
    //}
    #endregion

    #region version 2
    //try
    //{
    //    ((Derived)@base).Show();
    //    return;
    //}
    //catch
    //{}
    //try
    //{
    //    ((Child)@base).Show();
    //    return;
    //}
    //catch
    //{ }
    //try
    //{
    //    @base.Show();
    //    return;
    //}
    //catch
    //{ }
    #endregion

    #region version 3
    //if (@base is Derived)
    //{
    //    ((Derived)@base).Show();
    //}
    //else if (@base is Child child1)
    //{
    //    ((Child)@base).Show();
    //}
    //else
    //{
    //    @base.Show();
    //}
    #endregion

    #region version 4
    //var value = @base is Derived ? ((Derived)@base) : null;
    //value?.Show();

    //var value1 = @base as Derived;
    //var value2 = @base as Child;
    //var value3 = @base as Base;
    //value1?.Show();
    //value2?.Show();
    //value3?.Show();

    //(@base as Derived)?.Show();
    //(@base as Child)?.Show();
    //(@base as Base)?.Show();
    #endregion

    @base.Show();
}
