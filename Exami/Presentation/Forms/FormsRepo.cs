namespace Presentation.Forms;

public static class FormsRepo
{
    private static Dictionary<Type, Form> _forms = new Dictionary<Type, Form>();

    public static T GetForm<T>() where T : Form, new()
    {
        Type formType = typeof(T);

        if (!_forms.ContainsKey(formType) || _forms[formType] == null || _forms[formType].IsDisposed)
        {
            // Create a new instance if it doesn't exist or has been disposed
            _forms[formType] = new T();
        }

        return (T)_forms[formType];
    }
}
