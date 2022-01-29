using System.Collections.Generic;

public static class InterfaceHelper
{
    public static void ValidateInterfaces<T>(ref List<SingleInterfaceField<T>> list)
    {
        if (list == null)
            return;

        for (int i = list.Count - 1; i >= 0; i--)
        {
            list[i].Validate();
        }
    }

    public static void ValidateInterfaces<T>(ref SingleInterfaceField<T>[] array)
    {
        if (array == null)
            return;

        for (int i = array.Length - 1; i >= 0; i--)
        {
            array[i].Validate();
        }
    }
}
