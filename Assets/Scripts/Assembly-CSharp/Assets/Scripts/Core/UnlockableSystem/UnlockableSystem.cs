using System.Collections.Generic;
using Assets.Scripts.Core.UnlockableSystem.Cookies;

namespace Assets.Scripts.Core.UnlockableSystem
{
	public class UnlockableSystem
	{
		private CookiesMatcher cookiesMatcher;

		private Dictionary<int, Entity> entities;

		private Dictionary<int, Property> properties;

		private Dictionary<int, Metric> metrics;

		private Logger logger;

		public UnlockableSystem(Logger logger)
		{
		}

		public Entity getEntityById(int entityId)
		{
			return null;
		}

		public Dictionary<int, Entity> getEntities()
		{
			return null;
		}

		public Dictionary<int, Property> getProperties()
		{
			return null;
		}

		public Property getPropertyById(int propertyId)
		{
			return null;
		}

		public Metric getMetricById(int metricId)
		{
			return null;
		}

		public int getPropertyValue(int propertyId)
		{
			return 0;
		}

		public void setPropertyValue(int propertyId, int value)
		{
		}

		public void setCookiesMatcher(CookiesMatcher cookiesMatcher)
		{
		}

		public void updateMetric(int id, int value, string[] cookies)
		{
		}

		public void updateMetricWithPreferedProperties(int metricId, int value, string[] cookies, List<int> preferredProperties)
		{
		}

		public List<Property> findPropertiesByMetricId(int metricId, string[] cookies)
		{
			return null;
		}

		public List<Property> FindPropertiesByMetricIdWithoutCookies(int metricId)
		{
			return null;
		}

		public Property[] resetProperties(string[] tags)
		{
			return null;
		}

		public void addPropertiesValue(int[] propertiesIds, int value)
		{
		}

		public void addPropertyValue(int propertyId, int value)
		{
		}

		public Entity defineEntity(int id, int[] properties, bool unlocked)
		{
			return null;
		}

		public Property defineSyncedValueProperty(int id, SyncedValueProperty.Value value, ActivationRule activationRule, int activationValue, int initialValue, string[] tags, object[] cookies)
		{
			return null;
		}

		public Metric defineMetric(int id, int[] properties, string[] tags)
		{
			return null;
		}

		public Entity checkEntityById(int entityId)
		{
			return null;
		}

		public Entity[] checkEntities()
		{
			return null;
		}

		public void dump()
		{
		}

		private void checkEntityExisted(int entityId)
		{
		}

		private void checkPropertyExisted(int propertyId)
		{
		}

		private void checkMetricExisted(int metricId)
		{
		}

		private bool hasTag(Property property, string[] tags)
		{
			return false;
		}
	}
}
