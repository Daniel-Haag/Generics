namespace CacheGenerics
{
    public class Cache<T>
    {
        private readonly Dictionary<string, Tuple<T, DateTime>> _cache = new Dictionary<string, Tuple<T, DateTime>>();

        public void Adicionar(string chave, T valor, TimeSpan tempoExpiracao)
        {
            var expiracao = DateTime.UtcNow.Add(tempoExpiracao);
            _cache[chave] = Tuple.Create(valor, expiracao);
        }

        public T Obter(string chave)
        {
            if (_cache.TryGetValue(chave, out var entrada))
            {                
                if (DateTime.UtcNow > entrada.Item2)
                {
                    _cache.Remove(chave); 
                    return default; 
                }

                return entrada.Item1; 
            }

            return default;
        }

        public bool Remover(string chave)
        {
            return _cache.Remove(chave);
        }

        public bool Contem(string chave)
        {
            return _cache.ContainsKey(chave) && DateTime.UtcNow <= _cache[chave].Item2;
        }
    }
}
