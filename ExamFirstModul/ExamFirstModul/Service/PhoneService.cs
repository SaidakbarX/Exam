using ExamFirstModul.Models;

namespace ExamFirstModul.Service;

public class PhoneService
{
    private List<PhoneModel> _phone;
    public PhoneService()
    {
        _phone = new List<PhoneModel>();
    }
    public bool AddPhone(PhoneModel phone)
    {
        try
        {

            phone.Id = Guid.NewGuid();
            _phone.Add(phone);
            return true;
        }
        catch
        {

            return false;
        }
    }
    public PhoneModel GetByIdPhone(Guid id)
    {
        foreach (var phone in _phone)
        {
            if (phone.Id == id) return phone;
        }
        return null;
    }
    public bool UpdatePhone(Guid id)
    {
        var phoneId = GetByIdPhone(id);
        if (phoneId is null)
        {
            return false;
        }
        var index = _phone.IndexOf(phoneId);
        _phone[index] = phoneId;
        return true;

    }
    public bool DeletePhone(Guid id)
    {
        var phoneDelete = GetByIdPhone(id);
        if (phoneDelete is null)
        {
            return false;
        }
        _phone.Remove(phoneDelete);
        return true;
    }
    public List<PhoneModel> GetAllPhones()
    {
        return _phone;
    }
}
