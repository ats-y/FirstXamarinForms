using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xamarin.Forms;
using Notes.Models;

namespace Notes
{
    public partial class NotesPage : ContentPage
    {
        public NotesPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Pageが表示される直前のライフサイクル
        /// </summary>
        protected override void OnAppearing()
        {
            base.OnAppearing();

            var notes = new List<Note>();

            var files = Directory.EnumerateFiles(App.FolderPath, "*.notes.txt");
            foreach (var filename in files)
            {
                notes.Add(new Note
                {
                    Filename = filename,
                    Text = File.ReadAllText(filename),
                    Date = File.GetCreationTime(filename)
                });
            }

            listView.ItemsSource = notes
                .OrderBy(d => d.Date)
                .ToList();
        }

        /// <summary>
        /// ノート追加ボタンのクリックイベントハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        async void OnNoteAddedClicked(object sender, EventArgs e)
        {
            // ノート入力画面に移動する。
            Page entryPage = new NoteEntryPage
            {
                BindingContext = new Note()
            };
            await Navigation.PushAsync(entryPage);
        }

        async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new NoteEntryPage
                {
                    BindingContext = e.SelectedItem as Note
                });
            }
        }
    }
}