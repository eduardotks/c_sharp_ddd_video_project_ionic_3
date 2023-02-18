import { Component } from '@angular/core';
import { LoadingController, NavController } from '@ionic/angular';

@Component({
  selector: 'app-home',
  templateUrl: 'home.page.html',
  styleUrls: ['home.page.scss'],
})
export class HomePage {

  constructor(public navCtrl: NavController, private loadingCtrl: LoadingController) {}


  buscarVideo(tag : string)
  {
    console.log(tag)
    this.loadVideos(tag)
    if(tag == null || tag.trim()==''){
    }
  }

  async loadVideos(tag: string) {
    const loading = await this.loadingCtrl.create({
      message: "Buscando...",
      duration: 3000
    });

    await loading.present();
  }
}
