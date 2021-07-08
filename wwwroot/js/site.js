const inputCep = document.querySelector('#input-cep')
inputCep.addEventListener('input', (e) => {
  const cep = e.target.value;
  handleApiCep(cep)
});

function handleApiCep(cep){
  const checkCep = /^[0-9]{8}$/;
  if(checkCep.test(cep)){
    fetch(`https://viacep.com.br/ws/${cep}/json/`)
    .then(res => res.json())
    .then(data => handleAddress(data))
    .catch(err => console.log(err))
  } else{
    clearForm()
  }
}

function handleAddress(data){
  const street = data.logradouro;
  const district = data.bairro;
  const city = data.localidade;
  const state = data.uf;
  const address = `Rua: ${street}, Bairro: ${district}, ${city} - ${state}`;
  const cep = data.cep;
  document.querySelector('#address').value = address;
  document.querySelector('#cep').value = cep.replace("-", "");
}

function clearForm(){
  document.querySelector('#address').value = "";
  document.querySelector('#cep').value = "";
}
