namespace maidPro.ui;

public partial class TaskItem : ContentView
{
    int roomnumber = 0;
    public int RoomNumber
    {
        get
        {
            return roomnumber;
        }
        set
        {
            roomnumber = value;
            roomLabel.Text = roomnumber.ToString();

        }
    }

    CleanStatus clean = CleanStatus.CleanOccupied;

    public CleanStatus Clean
    {
        get
        {
            return clean;
        }

        set
        {
            clean = value;
            SetClean(value);
        }
    }


    RoomStatus roomStatus = RoomStatus.Pending;

    public RoomStatus RoomStatus
    {
        get
        {
            return roomStatus;
        }

        set
        {
            roomStatus = value;
            SetStatusRoom(value);
        }
    }

    public TaskItem()
    {
        InitializeComponent();
    }

    void SetClean(CleanStatus _clean)
    {
        switch (_clean)
        {
            case CleanStatus.CleanOccupied:
                cleanLabel.Text = "Clean Occupied";
                break;
            case CleanStatus.CleanVacant:
                cleanLabel.Text = "Clean Vacant";
                break;
            case CleanStatus.InspectedVacant:
                cleanLabel.Text = "Inspected Vacant";
                break;
            case CleanStatus.InspectedOccupied:
                cleanLabel.Text = "Inspected Occupied";
                break;
            case CleanStatus.DirtyVacant:
                cleanLabel.Text = "Dirty Vacant";
                break;
            case CleanStatus.DirtyOccupied:
                cleanLabel.Text = "Dirty Occupied";
                break;
        }
    }

    void SetStatusRoom(RoomStatus _roomStatus)
    {
        switch (_roomStatus)
        {
            case RoomStatus.Pending:
                roomStatusLabel.Text = "Pending";
                roomStatusLabel.BackgroundColor = Color.FromArgb("#F8E253"); 
                break;
            case RoomStatus.Assigned:
                roomStatusLabel.Text = "Assigned";
                roomStatusLabel.BackgroundColor = Color.FromArgb("#CE95E6");
                break;
            case RoomStatus.Inprogress:
                roomStatusLabel.Text = "Inprogress";
                roomStatusLabel.BackgroundColor = Color.FromArgb("#80D8DE");
                break;
            case RoomStatus.Completed:
                roomStatusLabel.Text = "Completed";
                roomStatusLabel.BackgroundColor = Color.FromArgb("#8DDD99");
                break;
            case RoomStatus.Inspected:
                roomStatusLabel.Text = "Inspected";
                roomStatusLabel.BackgroundColor = Color.FromArgb("#FFDD99");
                break;
        }
    }
}
public enum CleanStatus
{
    DirtyVacant = 1,
    DirtyOccupied = 2,
    CleanVacant = 3,
    CleanOccupied = 4,
    InspectedVacant = 5,
    InspectedOccupied = 6,
}


public enum RoomStatus
{
    Pending = 1,
    Assigned = 2,
    Inprogress = 3,
    Completed = 4,
    Inspected = 5
}