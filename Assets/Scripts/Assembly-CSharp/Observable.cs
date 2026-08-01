public interface Observable<T>
{
	void AddObserver(Observer<T> observer, ObserverType type);

	void RemoveObserver(Observer<T> observer);

	void NotifyObservers(ObserverType type);
}
