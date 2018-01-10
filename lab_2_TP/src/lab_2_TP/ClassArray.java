package lab_2_TP;

import java.io.Serializable;
import java.util.Dictionary;
import java.util.Hashtable;

public class ClassArray<T extends ITransport> implements Serializable {
	private static final long serialVersionUID = 1L;
	private T defaultValue;
	private Dictionary<Integer, T> places;
	int maxCount;

	public ClassArray(int size, T defVal) {
		defaultValue = defVal;
		places = new Hashtable<Integer, T>();
		maxCount = size;
	}

	public T getLiner(int ind) {
		if (places.get(ind) != null)
			return places.get(ind);
		return defaultValue;
	}

	public static <T extends ITransport> int plus(ClassArray<T> p, T ship) throws PortOverflowException
	{
	if (p.places.size() == p.maxCount) throw new PortOverflowException();
		for (int i = 0; i < p.places.size(); i++) {
			if (p.CheckFreePlace(i)) {
				p.places.put(i, ship);
				return i;
			}
		}
		p.places.put(p.places.size(), ship);
		return p.places.size() - 1;
	}

public static <T extends ITransport> T minus(ClassArray<T> p, int ind) throws PortIndexOutOfRangeException
{		
if (p.places.get(ind) != null) {
			T ship = p.places.get(ind);
			p.places.remove(ind);
			return ship;
		}
throw new PortIndexOutOfRangeException();
	}

	public boolean CheckFreePlace(int ind) {
		if (places.get(ind) == null) {
			return true;
		}

		return false;
	}

}

