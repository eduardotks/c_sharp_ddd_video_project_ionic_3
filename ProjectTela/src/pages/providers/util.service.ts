import { Injectable } from '@angular/core';
import { LoadingController, ToastController, AlertController } from '@ionic/angular';

import 'rxjs/add/operator/map';

@Injectable({
  providedIn: 'root'
})
export class UtilService {

  constructor(
    public loadCtrl: LoadingController,
    public toastCtrl: ToastController,
    public alertCtrl: AlertController,
  ) {
  }

  public obterHostDaApi(): string {
    return "http://localhost:55636/";
  }

  public showLoading(message: string = "Processando..."): any {
    let loading = this.loadCtrl.create({
      message: message

    });

    return loading;
  }

  async showToast(message: string, position: 'top' | 'bottom' = 'bottom'): Promise<void> {
    const toast = await this.toastCtrl.create({
      message: message,
      duration: 3000,
      position: position
    });

    await toast.present();
  }

  async showAlert(message: string, title: string = "Atenção"): Promise<void> {
    const alert = await this.alertCtrl.create({
      header: title,
      message: message,
      buttons: ['OK']
    });

    await alert.present();
  }

  async showAlertWithCallback(message: string, title: string = "Atenção", callback: () => void): Promise<void> {
    const alert = await this.alertCtrl.create({
      header: title,
      message: message,
      buttons: [{
        text: 'OK',
        handler: callback
      }]
    });

    await alert.present();
  }

  public isJson(json: string): boolean {
    try {
      JSON.parse(json);
    } catch (e) {
      return false;
    }

    return true;
  }

  public efetuarLogoff() {
    localStorage.clear();
  }

  showMessageError(response: Response) {

    //console.log('response=', response);
    //console.log('status=', response.status);

    if (response.status == 0) {
      this.showAlert("Serviço indisponível!");
    }
    else if (response.status == 401) {
      this.showAlertWithCallback("Autorização expirada, é necessário que se autentique novamente.", "", function () {
        localStorage.clear();
        //window.location.reload();
      });
    }
    else if (response.status == 415) {
      this.showToast('Desculpe, serviço indisponível, tento novamente mais tarde!');
    }
    else {

      let json: any = response.json();

      if (typeof json.error_description != 'undefined') {
          this.showToast(json.error_description);
      }
      else if (typeof json.errors != 'undefined') {
        for (let erro in json.errors) // for acts as a foreach
        {
          let message = json.errors[erro].message;

          this.showToast(message);

        }
      }
      else {
        this.showToast("Operação falhou!");
      }
    }
  }

  removerAcentos(str: string) {
    let com_acento = "ÀÁÂÃÄÅÆÇÈÉÊËÌÍÎÏÐÑÒÓÔÕÖØÙÚÛÜÝŔÞßàáâãäåæçèéêëìíîïðñòóôõöøùúûüýþÿŕ";
    let sem_acento = "AAAAAAACEEEEIIIIDNOOOOOOUUUUYRsBaaaaaaaceeeeiiiionoooooouuuuybyr";
    let novastr="";
    for(let i=0; i<str.length; i++) {
      let troca=false;
      for (let a=0; a<com_acento.length; a++) {
        if (str.substr(i,1)==com_acento.substr(a,1)) {
          novastr+=sem_acento.substr(a,1);
          troca=true;
          break;
        }
      }
      if (troca==false) {
        novastr+=str.substr(i,1);
      }
    }
    return novastr;
  }


}
