import { Component } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { FormControl, FormGroup, Validators, FormBuilder } from '@angular/forms';
import { Global } from '../Shared/Global';
@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
  cities: any;
  weather: any;
  WeatherForm: FormGroup;
  selectedCity: any;
  constructor(private http: HttpClient, private formBuilder: FormBuilder)
  {
    this.getCities();
  }

  ngOnInit() {
    this.WeatherForm = this.formBuilder.group({
      CityInfo: ['', Validators.required]
    });

  }

  getCities() {
    return this.http.get('/v1/GetCities').toPromise().then(res => {
      this.cities = res;
    });;
  }

  onSubmit(): void {
    this.selectedCity = this.WeatherForm.value.CityInfo;
    this.getWeatherInfo(this.selectedCity.toString());
  }

  getWeatherInfo(_cityInfo: string)
  {
    this.http.get('/v1/openWeatherMap/Information/' + _cityInfo).toPromise().then(res => {
      console.log(res);
       this.weather = res;
       console.log(this.weather);
     });;
  }



}
