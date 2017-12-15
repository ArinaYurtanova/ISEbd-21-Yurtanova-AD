package lab_2_TP;

public class ClassArray<T extends ITransport> {
	private T[] places;
	private T defaultValue;

	public ClassArray(int size, T defVal) {
		defaultValue = defVal;
		places = (T[]) new ITransport[size];
		for (int i = 0; i < places.length; i++) {
			places[i] = defaultValue;
		}
	}

	public T getObject(int ind) {
		if (ind > -1 && ind < places.length) {
			return places[ind];
		}
		return defaultValue;
	}

	public static <T extends ITransport> int plus(ClassArray<T> p, T ship) {
		for (int i = 0; i < p.places.length; i++) {
			if (p.CheckFreePlace(i)) {
				p.places[i] = ship;
				return i;
			}
		}
		return -1;
	}

	public static <T extends ITransport> T minus(ClassArray<T> p, int ind) {
		if (!p.CheckFreePlace(ind)) {
			T korabl = p.places[ind];
			p.places[ind] = p.defaultValue;
			return korabl;
		}
		return p.defaultValue;
	}

	public boolean CheckFreePlace(int ind) {
		if (ind < 0 || ind > places.length) {
			return false;
		}
		if (places[ind] == null) {
			return true;
		}
		if (places[ind].equals(defaultValue)) {
			return true;
		}

		return false;
	}

}